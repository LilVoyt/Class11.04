using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home
{
    internal class Sailor : Human
    {
        public string ShipName { get; set; }
        public Sailor(string name, string surname, int age, string adress, string shipName) : base(name, surname, age, adress)
        {
            Job = "Sailor";
            this.ShipName = shipName;
        }
        public override void PrintHuman()
        {
            base.PrintHuman();
            Console.WriteLine($"Job: {Job}, Ship name: {ShipName}");
        }
    }
}
