using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fold
{
    public static class ExpressionMatchExtensions
    {
        public static IEnumerable<Expression> Match(this LambdaExpression expression, LambdaExpression pattern)
        {
            //var patternSequence = pattern.Body.Iterate().ToList();
            //if (patternSequence.Count == 0)
            //{
            //    throw new ArgumentException("Invalid pattern", "pattern");
            //}

            //var rootNode = patternSequence[0];

            //var partialMatches = new List<PartialMatch>();

            //foreach (var node in expression.Iterate())
            //{
            //    partialMatches.Add(new PartialMatch { Root = node });

            //    for (var i = partialMatches.Count - 1; i >= 0; --i)
            //    {
            //        var partialMatch = partialMatches[i];
            //        if (Matches(node, patternSequence[partialMatch.Position]))
            //        {
            //            partialMatch.Position++;
            //            if (partialMatch.Position < patternSequence.Count)
            //            {
            //                continue;
            //            }
            //            yield return (Expression)partialMatch.Root.Element;
            //        }
            //        partialMatches.RemoveAt(i);
            //    }
            //}
        }

        private static Func<ExpressionIterationNode, bool> ParsePattern(LambdaExpression pattern)
        {


            //foreach (var node in pattern.Iterate())
            //{

            //}
        }

        //private static readonly MatchingStrategyDictionary _matchingStrategies = new MatchingStrategyDictionary()
            
        //    // A parameter matches anything of the same type
        //    .Add<ParameterExpression>((a, p) => p.Type.IsAssignableFrom(a.Type))

        //    .Add<MemberExpression>((a, p) => p.Member == a.Member)
        //;

        //private static bool Matches(ExpressionIterationNode actualNode, ExpressionIterationNode patternNode)
        //{
        //    var actualNodeType = actualNode.Element.GetType();
        //    var patternNodeType = patternNode.Element.GetType();

        //    if (actualNodeType != patternNodeType)
        //    {
        //        return false;
        //    }

        //    var testType = actualNodeType;
        //    while (testType != typeof(object))
        //    {
        //        IMatchingStrategy matchingStrategy;
        //        if (_matchingStrategies.TryGetValue(testType, out matchingStrategy))
        //        {
        //            return matchingStrategy.Matches(actualNode, patternNode);
        //        }

        //        testType = testType.BaseType;
        //    }

        //    return true;
        //}

        //private class MatchingStrategyDictionary : Dictionary<Type, IMatchingStrategy>
        //{
        //    public MatchingStrategyDictionary Add<TExpression>(Func<TExpression, TExpression, bool> predicate)
        //        where TExpression : Expression
        //    {
        //        Add(typeof(TExpression), new ExpressionMatchingStrategy<TExpression>(predicate));
        //        return this;
        //    }
        //}

        //private interface IMatchingStrategy
        //{
        //    bool Matches(ExpressionIterationNode actualNode, ExpressionIterationNode patternNode);
        //}

        //private sealed class ExpressionMatchingStrategy<TActualExpression, TPatternExpression> : IMatchingStrategy
        //    where TActualExpression : Expression
        //    where TPatternExpression : Expression
        //{
        //    private readonly Func<TExpression, TExpression, bool> predicate;

        //    public ExpressionMatchingStrategy(Func<TExpression, TExpression, bool> predicate)
        //    {
        //        this.predicate = predicate;
        //    }

        //    bool IMatchingStrategy.Matches(ExpressionIterationNode actualNode, ExpressionIterationNode patternNode)
        //    {
        //        return predicate((TExpression)actualNode.Element, (TExpression)patternNode.Element);
        //    }
        //}

        //private class PartialMatch
        //{
        //    public ExpressionIterationNode Root;
        //    public int Position;
        //}
    }
}
