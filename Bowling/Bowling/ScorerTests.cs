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

        [Test]
        public void Scorer_ThreeThrows_ThirdThrowIsInSecondFrame()
        {
            Scorer scorer = new Scorer();

            scorer.Throw(5);
            scorer.Throw(2);
            scorer.Throw(3);

            Assert.AreEqual(2, scorer.CurrentFrame);
        }

        [Test]
        public void Scorer_FourThrowsAndSpareInFirstFrame_SpareScoreBonus()
        {
            Scorer scorer = new Scorer();

            scorer.Throw(5);
            scorer.Throw(5);
            scorer.Throw(3);
            scorer.Throw(2);

            Assert.AreEqual(10 + 3 + 3 + 2, scorer.Score);
        }

        [Test]
        public void Scorer_Strike_StrikeScoreBonus()
        {
            Scorer scorer = new Scorer();

            scorer.Throw(10);
            scorer.Throw(3);
            scorer.Throw(2);

            Assert.AreEqual(10 + 3 + 2 + 3 + 2, scorer.Score);
        }
    }
}
