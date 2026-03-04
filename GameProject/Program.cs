namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball b1 = new Ball();

            Player salah = new Player("Salah");
            Player marmoush = new Player("Marmoush");
            Player aly = new Player("Aly");

            Referee r1 = new Referee();
            Audience a1 = new Audience();

            
            b1.BallPositionChanged += salah.MovePlayer;
            b1.BallPositionChanged += marmoush.MovePlayer;
            b1.BallPositionChanged += aly.MovePlayer;
            b1.BallPositionChanged += r1.MoveReferee;
            b1.BallPositionChanged += a1.RaiseHand;

            
            b1.ChangePosition();
            b1.ChangePosition();

            Console.ReadLine();
        }
    }
}
