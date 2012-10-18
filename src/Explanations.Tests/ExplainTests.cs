using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explanations.Tests
{
    [TestFixture]
    public class ExplainTests
    {
        [Test]
        public void Success_withoutContext_doesNothing()
        {
            Explain.Success("Sample");
            Assert.Pass();
        }

        [Test]
        public void Success_withContext_addsMessageToExplanation()
        {
            using (var m = new Explanation())
            {
                Explain.Success("Sample");
                Assert.That(m.Details, Has.Count.EqualTo(1));
            }
        }
    }
}
