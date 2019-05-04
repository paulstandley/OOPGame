using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGame
{
    class Battle // utilty class
    {
        // start fight
        // warrior1, warrior2
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {

            // loop to give each warrior a chance to acttack and block untill one dies
            while (true)
            {
                if(GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
            // getAttackResults
            // WarriorA WarriorB
 
            }
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            // calculate one warriors attack and the others block
            double warriorAAttack = warriorA.Attack();
            double warriorBBlock = warriorB.Block();

            // subtract block from attack
            double damageToB = warriorAAttack - warriorBBlock;

            // if there was damage subtract that from the health of the defender
            if (damageToB > 0)
            {
                warriorB.HealthMax = warriorB.HealthMax - damageToB;
            }
            else damageToB = 0;

            // Print out who attacked who and for how much damage
            Console.WriteLine("{0} deals a blow to {1} with the damage of {2}", warriorA.Name, warriorB.Name, damageToB);

            // provide info on change in health
            Console.WriteLine("{0} has {1} health \n", warriorB.Name, warriorB.HealthMax);

            // check if the warriors heath fell bellow zero if so then print message and stop loop
            if (warriorB.HealthMax <= 0)
            {
                Console.WriteLine("{0} has died and {1} is the victor", warriorB.Name, warriorA.Name);
                return "Game Over";
            }
            else return "Fight again";
        }
    }
}
