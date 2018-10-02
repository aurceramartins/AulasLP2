using System;

namespace MyFornite
{
    class Program
    {
        static void Main(string[] args)
        {
            FNPlayer player1 = new FNPlayer();
            FNPlayer player2 = new FNPlayer(100, 50);

            Console.WriteLine("O p2 ten agora " + player2.Health);
            player1.Attack(player2);
            Console.WriteLine("O p2 ten agora " + player2.Health);

        }
    }
}
