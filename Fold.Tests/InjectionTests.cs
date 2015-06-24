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
    public class InjectionTests
    {
        [Fact]
        public void Expression_is_injected()
        {
            Expression<Func<Dto, bool>> condition = y => y.Item1.Length > 1;

            Expression<Func<Dto, bool>> template = x => x.Item2 == 3 && Inject.Expression(x, condition);

            Expression<Func<Dto, bool>> predicate = template.Transform();

            Func<Dto, bool> del = predicate.Compile();

            Assert.True(del(new Dto("abc", 3)));
            Assert.False(del(new Dto("abc", 2)));
            Assert.False(del(new Dto("x", 3)));
        }
    }
}
