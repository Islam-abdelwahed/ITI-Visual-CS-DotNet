using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class Player
    {
        public string Name { get; }

        public Player(string name)
        {
            Name = name;
        }

        public void MovePlayer(object sender, BallEventArgs e)
        {
            Console.WriteLine(
                $"Player {Name} moves by ({e.DeltaX},{e.DeltaY})"
            );
        }
    }
}
