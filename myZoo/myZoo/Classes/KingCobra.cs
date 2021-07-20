using System;
using System.Collections.Generic;
using System.Text;

namespace myZoo.Classes
{
    public class KingCobra : Snake
    {
        public string OfType { get; set; } = nameof(KingCobra);
        public string OfAnimal { get; set; } = nameof(Snake);
        public override string ScalePattern { get; set; } = "No pattern. Solid Color";
        public override bool CanKill { get; set; } = true;
        public override string Climate { get; set; } = "Tropical";

        public override int Bite()
        {
            Console.WriteLine($"The {OfType} {OfAnimal} strikes, and now you're dead.");
            return 1; 
        }

        public override void Fight(int i)
        {
            if (i >= Enemies.Length)
            {
                Console.WriteLine($"OutofBounds, Select a number between 0-{Enemies.Length}");
            }
            else
            {
                Console.WriteLine($"The {OfType} {OfAnimal} is attacking a {Enemies[i]}");
            }
        }

        public override void RunAway()
        {
            Console.WriteLine($"The {OfType} {OfAnimal} ran away.");
        }
    }
}
