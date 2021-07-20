using System;
using myZoo.Classes;

namespace myZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bengel bob = new Bengel();
            KingCobra snek = new KingCobra();
            African dumbo = new African();

            Console.WriteLine(dumbo.CanFly);
        }
    }
}
