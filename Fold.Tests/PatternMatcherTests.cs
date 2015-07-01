using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Dto = System.Tuple<string, int>;

namespace Fold.Tests
{
    public class PatternMatcherTests
    {
        [Fact]
        public void Can_match_string_length_pattern()
        {
            Expression<Func<Dto, int>> projection = x => x.Item1.Length + x.Item2;

            Expression<Func<string, int>> pattern = s => s.Length;

            var matches = projection.Match(pattern);

            Assert.Equal(1, matches.Count());
        }
    }
}
