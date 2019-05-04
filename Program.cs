using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcom player one to the death match please give Warrior a name");
            string player1Name = Console.ReadLine();
            Console.WriteLine("Welcom player two to the death match please give Warrior a name");
            string player2Name = Console.ReadLine();

            Warrior Player1 = new Warrior(player1Name, 44, 12, 3);

            Warrior Player2 = new Warrior(player2Name, 44, 12, 3);

            Battle.StartFight(Player1, Player2);

            Console.ReadLine();
        }
    }
}
