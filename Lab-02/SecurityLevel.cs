using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_02
{
    [Flags]
    public enum SecurityLevel : byte
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8,
        FullPermissions = Guest | Developer | Secretary | DBA
    }
}
