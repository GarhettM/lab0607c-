using System;
using System.Collections.Generic;
using System.Text;

namespace myZoo.Classes
{
    public class African : Elephant
    {
        public string OfType { get; set; } = nameof(Asian);
        public string OfAnimal { get; set; } = nameof(Elephant);
        public override string SizeEars { get; set; } = "Large";
        public override bool CanFly { get; set; } = true;
        public override string[] Enemies { get; set; } = { "People", "Lions", "Hyenas" };

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

        public override void HuddleWithHeard()
        {
            Console.WriteLine("This elephant ain't got time to huddle.");
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
