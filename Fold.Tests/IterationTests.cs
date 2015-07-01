using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Fold.Tests
{
    public class IterationTests
    {
        private class ExpressionIterationNodeAssertionList : List<Func<ExpressionIterationNode, bool>>
        {
            public ExpressionIterationNodeAssertionList Add<TExpression>(Func<TExpression, bool> assertion = null)
                where TExpression : Expression
            {
                Add(n =>
                {
                    var expression = n.Element as TExpression;
                    return expression != null && (assertion == null || assertion(expression));
                });
                return this;
            }
        }

        [Fact]
        public void Iteration_of_string_length_lambda_yields_the_correct_expressions()
        {
            Expression<Func<string, int>> expression = x => x.Length;

            var expected = new ExpressionIterationNodeAssertionList()
                .Add<LambdaExpression>()
                .Add<ParameterExpression>(e => e.Name == "x")
                .Add<MemberExpression>(e => e.Member.Name == "Length")
                .Add<ParameterExpression>(e => e.Name == "x")
            ;

            var actual = expression.Iterate().ToList();

            Assert.Equal(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; ++i)
            {
                Assert.True(expected[i](actual[i]));
            }
        }

        [Fact]
        public void Iteration_of_string_method_calls_yields_the_correct_expressions()
        {
            Expression<Func<string, bool>> expression = x => x.Contains("abc") || x.GetEnumerator().MoveNext();

            var expected = new ExpressionIterationNodeAssertionList()
                .Add<LambdaExpression>()
                .Add<ParameterExpression>(e => e.Name == "x")
                .Add<BinaryExpression>(e => e.NodeType == ExpressionType.OrElse)
                .Add<MethodCallExpression>(e => e.Method.Name == "Contains")
                .Add<ParameterExpression>(e => e.Name == "x")
                .Add<ConstantExpression>(e => e.Value.Equals("abc"))
                .Add<MethodCallExpression>(e => e.Method.Name == "MoveNext")
                .Add<MethodCallExpression>(e => e.Method.Name == "GetEnumerator")
                .Add<ParameterExpression>(e => e.Name == "x")
            ;

            var actual = expression.Iterate().ToList();

            Assert.Equal(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; ++i)
            {
                Assert.True(expected[i](actual[i]));
            }
        }
    }
}
