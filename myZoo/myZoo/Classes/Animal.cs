using System;
using System.Collections.Generic;
using System.Text;

namespace myZoo.Classes
{
    public abstract class Animal
    {
        public abstract int NumOfLegs { get; set; }
        public abstract bool IsRideable { get; set; }
        public virtual string Weapon { get; set; } = "This Animal is defenseless.";

        public abstract void Fight(int i);
        public abstract void RunAway();
    }
}
