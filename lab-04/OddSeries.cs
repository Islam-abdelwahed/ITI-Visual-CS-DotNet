using System;
using System.Collections.Generic;
using System.Text;

namespace lab_04
{
    internal class OddSeries : ISeries
    {
        int nextNumber;

        public OddSeries()
        {
            nextNumber = 1;
        }

        public int GetNextNumber()
        {
            int d = nextNumber;
            nextNumber += 2;
            return d;
        }
    }
}
