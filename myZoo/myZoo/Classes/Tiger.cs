using System;
using System.Collections.Generic;
using System.Text;

namespace myZoo.Classes
{
    public abstract class Tiger : Animal
    {
        public override int NumOfLegs { get; set; } = 4;
        public override string Weapon { get; set; } = "Claws, and Fangs";
        public override bool IsRideable { get; set; } = false;
        
        public abstract string OfType { get; set; }
        public virtual string Color { get; set; } = "Orange";
        public abstract string[] Prey { get; set; }

        public virtual void ClimbATree()
        {
            Console.WriteLine("This Tiger is Climbing a tree!");
        }
    }
}
