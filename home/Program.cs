using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Builder("Oleg", "Voyt", 14, "Lviv", "Walls");
            human.PrintHuman();
            Human human1 = new Human();
            Console.WriteLine(Human.Count);
            Human human2 = new Sailor("Roman", "Somebody", 23, "Lviv", "Titanic(");
            human2.PrintHuman();
        }
    }
}
