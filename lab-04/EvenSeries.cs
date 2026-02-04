using System;
using System.Collections.Generic;
using System.Text;

namespace lab_04
{
    internal class EvenSeries : ISeries
    {
        int nextNumber = 0;

        public int GetNextNumber()
        {
            int d = nextNumber;
            nextNumber += 2;
            return d;
        }
    }
}
