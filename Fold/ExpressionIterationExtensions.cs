using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Fold
{
    public static class ExpressionIterationExtensions
    {
        public static IEnumerable<ExpressionIterationNode> Iterate(this Expression expression)
        {
            return expression.IterateInternal(null).Flatten();
        }

        private static IEnumerable<ExpressionIterationNode> Flatten(this IEnumerable<object> sequence)
        {
            foreach (var item in sequence)
            {
                var subSequence = item as IEnumerable<object>;
                if (subSequence != null)
                {
                    foreach (var subItem in subSequence.Flatten())
                    {
                        yield return subItem;
                    }
                }
                else
                {
                    yield return (ExpressionIterationNode)item;
                }
            }
        }

        private static IEnumerable<object> IterateInternal(this Expression expression, ExpressionIterationNode parent)
        {
            var current = new ExpressionIterationNode(parent, expression);
            yield return current;

            if (expression == null)
            {
                yield break;
            }

            IEnumerable<ExpressionIterationNode> children;
            switch (expression.NodeType)
            {
                case ExpressionType.Add:
                case ExpressionType.AddAssign:
                case ExpressionType.AddAssignChecked:
                case ExpressionType.AddChecked:
                case ExpressionType.And:
                case ExpressionType.AndAlso:
                case ExpressionType.AndAssign:
                case ExpressionType.ArrayIndex:
                case ExpressionType.Assign:
                case ExpressionType.Coalesce:
                case ExpressionType.Divide:
                case ExpressionType.DivideAssign:
                case ExpressionType.Equal:
                case ExpressionType.ExclusiveOr:
                case ExpressionType.ExclusiveOrAssign:
                case ExpressionType.GreaterThan:
                case ExpressionType.GreaterThanOrEqual:
                case ExpressionType.LeftShift:
                case ExpressionType.LeftShiftAssign:
                case ExpressionType.LessThan:
                case ExpressionType.LessThanOrEqual:
                case ExpressionType.Modulo:
                case ExpressionType.ModuloAssign:
                case ExpressionType.Multiply:
                case ExpressionType.MultiplyAssign:
                case ExpressionType.MultiplyAssignChecked:
                case ExpressionType.MultiplyChecked:
                case ExpressionType.NotEqual:
                case ExpressionType.Or:
                case ExpressionType.OrAssign:
                case ExpressionType.OrElse:
                case ExpressionType.Power:
                case ExpressionType.PowerAssign:
                case ExpressionType.RightShift:
                case ExpressionType.RightShiftAssign:
                case ExpressionType.Subtract:
                case ExpressionType.SubtractAssign:
                case ExpressionType.SubtractAssignChecked:
                case ExpressionType.SubtractChecked:
                    {
                        var binary = (BinaryExpression)expression;
                        yield return binary.Left.IterateInternal(current);
                        yield return binary.Right.IterateInternal(current);
                    }
                    break;

                case ExpressionType.ArrayLength:
                case ExpressionType.Convert:
                case ExpressionType.ConvertChecked:
                case ExpressionType.Decrement:
                case ExpressionType.Increment:
                case ExpressionType.IsFalse:
                case ExpressionType.IsTrue:
                case ExpressionType.Negate:
                case ExpressionType.NegateChecked:
                case ExpressionType.Not:
                case ExpressionType.OnesComplement:
                case ExpressionType.PostDecrementAssign:
                case ExpressionType.PostIncrementAssign:
                case ExpressionType.PreDecrementAssign:
                case ExpressionType.PreIncrementAssign:
                case ExpressionType.Quote:
                case ExpressionType.Throw:
                case ExpressionType.TypeAs:
                case ExpressionType.UnaryPlus:
                case ExpressionType.Unbox:
                    {
                        var unary = (UnaryExpression)expression;
                        yield return unary.Operand.IterateInternal(current);
                    }
                    break;

                case ExpressionType.Call:
                    {
                        var call = (MethodCallExpression)expression;
                        yield return call.Object.IterateInternal(current);
                        foreach (var argument in call.Arguments)
                        {
                            yield return argument.IterateInternal(current);
                        }
                    }
                    break;

                case ExpressionType.Conditional:
                    {
                        var conditional = (ConditionalExpression)expression;
                        yield return conditional.Test.IterateInternal(current);
                        yield return conditional.IfTrue.IterateInternal(current);
                        yield return conditional.IfFalse.IterateInternal(current);
                    }
                    break;

                case ExpressionType.Invoke:
                    {
                        var invocation = (InvocationExpression)expression;
                        yield return invocation.Expression.IterateInternal(current);
                        foreach (var argument in invocation.Arguments)
                        {
                            yield return argument.IterateInternal(current);
                        }
                    }
                    break;

                case ExpressionType.Lambda:
                    {
                        var lambda = (LambdaExpression)expression;
                        foreach (var parameter in lambda.Parameters)
                        {
                            yield return parameter.IterateInternal(current);
                        }
                        yield return lambda.Body.IterateInternal(current);
                    }
                    break;

                case ExpressionType.ListInit:
                    {
                        var listInit = (ListInitExpression)expression;
                        yield return listInit.NewExpression.IterateInternal(current);
                        foreach (var initializer in listInit.Initializers)
                        {
                            var initializerNode = new ExpressionIterationNode(current, initializer);
                            yield return initializerNode;
                            foreach (var argument in initializer.Arguments)
                            {
                                yield return argument.IterateInternal(initializerNode);
                            }
                        }
                    }
                    break;

                case ExpressionType.MemberAccess:
                    {
                        var memberAccess = (MemberExpression)expression;
                        yield return memberAccess.Expression.IterateInternal(current);
                    }
                    break;

                case ExpressionType.MemberInit:
                    {
                        var memberInit = (MemberInitExpression)expression;
                        yield return memberInit.NewExpression.IterateInternal(current);
                        yield return IterateBindings(current, memberInit.Bindings);
                    }
                    break;

                case ExpressionType.New:
                    {
                        var newExpr = (NewExpression)expression;
                        foreach (var argument in newExpr.Arguments)
                        {
                            yield return argument.IterateInternal(current);
                        }
                    }
                    break;

                case ExpressionType.NewArrayInit:
                case ExpressionType.NewArrayBounds:
                    {
                        var newArray = (NewArrayExpression)expression;
                        foreach (var expr in newArray.Expressions)
                        {
                            yield return expr.IterateInternal(current);
                        }
                    }
                    break;

                case ExpressionType.TypeEqual:
                case ExpressionType.TypeIs:
                    {
                        var typeBinary = (TypeBinaryExpression)expression;
                        yield return typeBinary.Expression.IterateInternal(current);
                    }
                    break;

                case ExpressionType.Block:
                    {
                        var block = (BlockExpression)expression;
                        // TODO: Variables
                        foreach (var expr in block.Expressions)
                        {
                            yield return expr.IterateInternal(current);
                        }
                    }
                    break;

                case ExpressionType.Dynamic:
                    {
                        var dyn = (DynamicExpression)expression;
                        foreach (var argument in dyn.Arguments)
                        {
                            yield return argument.IterateInternal(current);
                        }
                    }
                    break;

                case ExpressionType.Index:
                    {
                        var index = (IndexExpression)expression;
                        yield return index.Object.IterateInternal(current);
                        foreach (var argument in index.Arguments)
                        {
                            yield return argument.IterateInternal(current);
                        }
                    }
                    break;

                case ExpressionType.Default:
                case ExpressionType.DebugInfo:
                case ExpressionType.Parameter:
                case ExpressionType.Constant:
                case ExpressionType.RuntimeVariables:
                    // Do nothing
                    yield break;

                case ExpressionType.Loop:
                case ExpressionType.Switch:
                case ExpressionType.Try:
                case ExpressionType.Label:
                case ExpressionType.Goto:
                case ExpressionType.Extension:
                    throw new NotSupportedException("Unsupported expression type: " + expression.NodeType);

                default:
                    throw new ArgumentOutOfRangeException("expression", expression.NodeType, "Invalid expression type");
            }

            yield break;
        }

        private static IEnumerable<object> IterateBindings(ExpressionIterationNode parent, IEnumerable<MemberBinding> bindings)
        {
            foreach (var binding in bindings)
            {
                var bindingNode = new ExpressionIterationNode(parent, binding);
                yield return bindingNode;

                switch (binding.BindingType)
                {
                    case MemberBindingType.Assignment:
                        yield return ((MemberAssignment)binding).Expression.IterateInternal(bindingNode);
                        break;

                    case MemberBindingType.ListBinding:
                        foreach (var initializer in ((MemberListBinding)binding).Initializers)
                        {
                            var initializerNode = new ExpressionIterationNode(bindingNode, initializer);
                            yield return initializerNode;
                            foreach (var argument in initializer.Arguments)
                            {
                                yield return argument.IterateInternal(initializerNode);
                            }
                        }
                        break;

                    case MemberBindingType.MemberBinding:
                        yield return IterateBindings(bindingNode, ((MemberMemberBinding)binding).Bindings);
                        break;

                    default:
                        throw new NotSupportedException("Unsupported MemberBindingType: " + binding.BindingType);
                }
            }
        }
    }

    public class ExpressionIterationNode
    {
        public ExpressionIterationNode ParentNode { get; private set; }
        public object Element { get; private set; }

        public ExpressionIterationNode(ExpressionIterationNode parentNode, object element)
        {
            ParentNode = parentNode;
            Element = element;
        }
    }
}
