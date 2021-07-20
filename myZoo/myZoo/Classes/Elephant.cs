using System;
using System.Collections.Generic;
using System.Text;

namespace myZoo.Classes
{
    public abstract class Elephant : Animal
    {
        public override int NumOfLegs { get; set; } = 4;
        public override bool IsRideable { get; set; } = true;
        public override string Weapon { get; set; } = "Tusks";

        public abstract string SizeEars { get; set; }
        public abstract bool CanFly { get; set; }
        public abstract string[] Enemies { get; set; }

        public virtual void HuddleWithHeard()
        {
            Console.WriteLine("This elephant is huddleing with the heard!");
        }

        public abstract void ElephantCharge();
    }
}
