using System;
using System.Collections.Generic;
using System.Text;

namespace myZoo.Classes
{
    public class Bengel : Tiger
    {
        public override string OfType { get; set; } = nameof(Bengel);
        public override string[] Prey { get; set; } = { "Antelope", "Bird", "Human" };
        public override string Color { get => base.Color; set => base.Color = value; }
        public string OfAnimal { get; set; } = nameof(Tiger);

        public override void Fight(int i)
        {
            if (i >= Prey.Length)
            {
                Console.WriteLine($"OutofBounds, Select a number between 0-{Prey.Length}");
            }
            else
            {
                Console.WriteLine($"The {OfType} {OfAnimal} is attacking a {Prey[i]}");
            }
        }

        public override void RunAway()
        {
            Console.WriteLine($"The {OfType} {OfAnimal} ran away.");
        }
    }
}
