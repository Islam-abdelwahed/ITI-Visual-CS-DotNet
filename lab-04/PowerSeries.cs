using System;
using System.Collections.Generic;
using System.Text;

namespace lab_04
{
    internal class PowerSeries : ISeries
    {
        int nxtNumber = 1;

        public int GetNextNumber()
        {
            int d = nxtNumber;
            nxtNumber *= 2;
            return d;
        }
    }
}
