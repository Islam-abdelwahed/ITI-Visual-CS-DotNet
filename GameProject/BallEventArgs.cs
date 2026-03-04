using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class BallEventArgs : EventArgs
    {
        public int DeltaX { get; }
        public int DeltaY { get; }

        public BallEventArgs(int dx, int dy)
        {
            DeltaX = dx;
            DeltaY = dy;
        }
    }
}
