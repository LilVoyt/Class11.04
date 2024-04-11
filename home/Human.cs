using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home
{
    internal class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public virtual string Adress { get; set; }
        public string Job { get; set; }
        public static int Count { get; set; } = 0;
        public Human()
        {
            Count++;
        }
        public Human (string name, string surname, int age, string adress) : this()
        {
            Name = name;
            Surname = surname;
            Age = age;
            Adress = adress;
        }
        public virtual void PrintHuman()
        {
            Console.WriteLine($"{Name} {Surname} has {Age} years. From {Adress}");
        }
    }
}
