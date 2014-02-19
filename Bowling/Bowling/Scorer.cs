using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bowling
{
    class Scorer
    {
        private readonly int[] _throws = new int[21];
        private int _throwIndex;

        internal void Throw(int pins)
        {
            _throws[_throwIndex] = pins;

            if (pins == 10 && (_throwIndex == 0 || _throws[_throwIndex - 1] == 0)) // Strike
            {
                _throws[_throwIndex + 1] = 0;
                _throwIndex++;
            }

            _throwIndex++;
        }

        public object Score
        {
            get
            {
                int score = 0;
                int throwIndex = 0;

                for (int frame = 0; frame < 10; frame++)
                {

                    if (_throws[throwIndex] == 10) // Strike
                    {
                        score += 10 + _throws[throwIndex + 2] + _throws[throwIndex + 3];
                    }
                    else
                    {
                        int scoreFrame = _throws[throwIndex] + _throws[throwIndex + 1];

                        if (scoreFrame == 10) // Spare
                        {
                            score += 10 + _throws[throwIndex + 2];
                        }
                        else
                        {
                            score += scoreFrame;
                        }    
                    }
                    
                    throwIndex += 2;
                }

                return score;
            }
        }

        public object CurrentFrame
        {
            get { return _throws.Length % 2 + 1; }
        }
    }
}
