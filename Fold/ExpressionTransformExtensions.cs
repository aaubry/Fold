using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Fold
{
    public static class ExpressionTransformExtensions
    {
        public static Expression<TFunc> Transform<TFunc>(this Expression<TFunc> expression)
        {
            var visitor = new TransformVisitor();
            var transformed = visitor.Visit(expression);
            return (Expression<TFunc>)transformed;
        }

        private class TransformVisitor : ExpressionVisitor
        {
            private readonly List<Tuple<ParameterExpression, Expression>> parameterReplacements = new List<Tuple<ParameterExpression, Expression>>();

            protected override Expression VisitMethodCall(MethodCallExpression node)
            {
                if (node.Method.DeclaringType == typeof(Inject))
                {
                    var argCount = node.Arguments.Count - 1;
                    var lambda = node.Arguments[argCount].EvaluateConstant<LambdaExpression>();

                    // Enqueue new parameter replacements
                    for (int i = 0; i < argCount; ++i)
                    {
                        parameterReplacements.Add(Tuple.Create(lambda.Parameters[i], node.Arguments[i]));
                    }

                    var body = Visit(lambda.Body);

                    // Dequeue the parameter replacements
                    parameterReplacements.RemoveRange(parameterReplacements.Count - argCount, argCount);

                    return body;
                }

                return base.VisitMethodCall(node);
            }

            protected override Expression VisitParameter(ParameterExpression node)
            {
                var replacement = parameterReplacements.FirstOrDefault(r => r.Item1 == node);
                return replacement != null
                    ? replacement.Item2
                    : base.VisitParameter(node);
            }
        }

        public static T EvaluateConstant<T>(this Expression expression)
        {
            switch (expression.NodeType)
            {
                case ExpressionType.Constant:
                    return (T)((ConstantExpression)expression).Value;

                default:
                    var lambda = Expression.Lambda<Func<T>>(expression);
                    return lambda.Compile()();
            }
        }
    }
}
