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

            Warrior Player1 = new Warrior("Fred", 1000, 120, 40);

            Warrior Player2 = new Warrior("Jim", 1000, 120, 40);

            Battle.StartFight(Player1, Player2);

            Console.ReadLine();
        }
    }
}
