using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home
{
    internal class Builder : Human
    {
        public string Specialisation { get; set; }
        public Builder(string name, string surname, int age, string adress, string specialisation) : base(name, surname, age, adress)
        {
            Job = "Builder";
            Specialisation = specialisation;
        }
        public override void PrintHuman()
        {
            base.PrintHuman();
            Console.WriteLine($"Job: {Job}, Specialisation: {Specialisation}");
        }
    }
}
