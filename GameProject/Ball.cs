using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class Ball
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public event EventHandler<BallEventArgs> BallPositionChanged;

        public void ChangePosition()
        {
            int oldX = X;
            int oldY = Y;

            X++;
            Y++;

            int dx = X - oldX;
            int dy = Y - oldY;

            BallPositionChanged?.Invoke(
                this,
                new BallEventArgs(dx, dy)
            );
        }
    }
}
