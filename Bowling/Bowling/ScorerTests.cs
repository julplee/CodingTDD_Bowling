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

        [Test]
        public void Scorer_TwoThrows_ScoreAdded()
        {
            Scorer scorer = new Scorer();

            scorer.Throw(5);
            scorer.Throw(2);

            Assert.AreEqual(5 + 2, scorer.Score);
        }
    }
}
