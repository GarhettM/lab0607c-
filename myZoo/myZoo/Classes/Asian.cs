using System;
using System.Collections.Generic;
using System.Text;

namespace myZoo.Classes
{
    public class Asian : Elephant
    {
        public string OfType { get; set; } = nameof(Asian);
        public string OfAnimal { get; set; } = nameof(Elephant);
        public override string SizeEars { get; set; } = "Small";
        public override bool CanFly { get; set; } = false;
        public override string[] Enemies { get; set; } = { "People", "Fly's", "Tigers" };

        public override void Fight(int i)
        {
            if (i >= Enemies.Length)
            {
                Console.WriteLine($"OutofBounds, Select a number between 0-{Enemies.Length}");
            }
            else
            {
                Console.WriteLine($"The {OfType} {OfAnimal} is attacking a group of {Enemies[i]}");
            }
        }

        public override void RunAway()
        {
            Console.WriteLine($"The {OfType} {OfAnimal} ran away.");
        }

        public override void ElephantCharge()
        {
            Console.WriteLine($"The {OfType} {OfAnimal} charged and murdered everything!");
        }
    }
}
