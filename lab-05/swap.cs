using System;
using System.Collections.Generic;
using System.Text;

namespace lab_05
{
    internal class Task1
    {
        public static void Swap<t1>(ref t1 x,ref t1 y)/* where t1:ICloneable, IComparable*/
        {
            t1 temp = x;
            x = y;
            y = temp;
        }
    }
}
