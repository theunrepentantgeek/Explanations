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

        [Test]
        public void Failure_withoutContext_doesNothing()
        {
            Explain.Failure("Sample");
            Assert.Pass();
        }

        [Test]
        public void Failure_withContext_addsMessageToExplanation()
        {
            using (var m = new Explanation())
            {
                Explain.Failure("Sample");
                Assert.That(m.Details, Has.Count.EqualTo(1));
            }
        }

        [Test]
        public void Decision_withoutContext_doesNothing()
        {
            Explain.Decision("Sample");
            Assert.Pass();
        }

        [Test]
        public void Decision_withContext_addsMessageToExplanation()
        {
            using (var m = new Explanation())
            {
                Explain.Decision("Sample");
                Assert.That(m.Details, Has.Count.EqualTo(1));
            }
        }

        [Test]
        public void Step_withoutContext_doesNothing()
        {
            Explain.Step("Sample");
            Assert.Pass();
        }

        [Test]
        public void Step_withContext_addsMessageToExplanation()
        {
            using (var m = new Explanation())
            {
                Explain.Step("Sample");
                Assert.That(m.Details, Has.Count.EqualTo(1));
            }
        }
    }
}
