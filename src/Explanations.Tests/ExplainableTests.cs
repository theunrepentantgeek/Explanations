using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explanations.Tests
{
    [TestFixture]
    public class ExplainableTests
    {
        [Test]
        public void Explainable_withNoMessages_hasNoMessages()
        {
            Explainable<int> result;
            using (new Explanation())
            {
                result = new Explainable<int>(19);
            }

            Assert.That(result.Messages, Is.Empty);
        }

        [Test]
        public void Explainable_withMessages_hasMessages()
        {
            Explainable<int> result;
            using (new Explanation())
            {
                Explain.Success("Sample Message");
                result = new Explainable<int>(19);
            }

            Assert.That(result.Messages, Has.Count.EqualTo(1));
        }
    }
}
