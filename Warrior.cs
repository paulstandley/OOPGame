using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGame
{
    class Warrior
    {
        // name, health, attack maximum, block maximum
        public string Name { get; set; } = "Warrior";
        public double HealthMax { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;
        // get random numbers, use the same instance so as not to pass the same values
        Random GetRandom = new Random();
        
        public Warrior(string name = "Warrrior", double health = 0, double attackMax = 0, double block = 0)
        {
            Name = name;
            HealthMax = health;
            AttackMax = attackMax;
            BlockMax = block;
        }

        // attack generate a random number from 1 to maximum value
        public double Attack()
        {
            return GetRandom.Next(1, (int)AttackMax);
        }

        // block generate a random number from 1 to maximum value
        public double Block()
        {
            return GetRandom.Next(1, (int)BlockMax);
        }
       
    }
}
