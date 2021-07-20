using System;
using System.Collections.Generic;
using System.Text;

namespace myZoo.Classes
{
    public abstract class Snake : Animal
    {
        public override int NumOfLegs { get; set; } = 0;
        public override bool IsRideable { get; set; } = false;
        public override string Weapon { get; set; } = "Fangs";

        public abstract string ScalePattern { get; set; }
        public abstract bool CanKill { get; set; }
        public abstract string Climate { get; set; }
        public virtual string[] Enemies { get; set; } = { "People", "Mongeese", "Other Bigger Snakes" };

        public abstract int Bite();
    }
}
