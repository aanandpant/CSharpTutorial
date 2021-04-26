using WarriorWars.Enum;
using System;
using System.Threading;

namespace WarriorWars
{
    class EntryPoint
    {
        static Random rand = new Random();
        static void Main()
        {
            Warrior goodGuy = new Warrior("Aanand", Faction.GoodGuy);
            Warrior badGuy = new Warrior("El chapo", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rand.Next(0,10)<5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }

                Thread.Sleep(50);
            }
            
        }
    }
}
