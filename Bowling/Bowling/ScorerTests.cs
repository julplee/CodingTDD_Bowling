using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Bowling
{
    [TestFixture]
    public class ScorerTests
    {
        [Test]
        public void Scorer_ThrowFivePins_ScoreEqualFive()
        {
            Scorer scorer = new Scorer();

            scorer.Throw(5);

            Assert.AreEqual(5, scorer.Score);
        }
    }
}
