using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    internal class Audience
    {
        public void RaiseHand(object sender, BallEventArgs e)
        {
            Console.WriteLine("Audience raises hands 🙌");
        }
    }
}
