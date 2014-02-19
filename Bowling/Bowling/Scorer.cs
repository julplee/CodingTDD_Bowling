using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bowling
{
    class Scorer
    {
        private int[] _throws = new int[21];
        private int _throwIndex;

        internal void Throw(int pins)
        {
            _throws[_throwIndex] = pins;
            _throwIndex++;
        }

        public object Score
        {
            get { return _throws.Sum(); }
        }

        public object CurrentFrame
        {
            get { return _throws.Length % 2 + 1; }
        }
    }
}
