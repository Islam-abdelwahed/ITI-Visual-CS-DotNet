using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class Referee
    {
        public void MoveReferee(object sender, BallEventArgs e)
        {
            Console.WriteLine(
                $"Referee moves by ({e.DeltaX},{e.DeltaY})"
            );
        }
    }
}
