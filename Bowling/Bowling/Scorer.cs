using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bowling
{
    class Scorer
    {
        private int _score;

        internal void Throw(int pins)
        {
            _score += pins;
        }

        public object Score
        {
            get
            {
                return _score;
            }
        }
    }
}
