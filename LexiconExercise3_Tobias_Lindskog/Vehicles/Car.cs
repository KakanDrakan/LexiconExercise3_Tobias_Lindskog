using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_Tobias_Lindskog.Vehicles
{
    internal class Car: Vehicle, ICleanable
    {
        private string color;
        public string Color;
        public Car() 
        {
            color = "red";
        }

        public override void SetUniqueTrait()
        {
            Console.Write("Color: ");
            color = Console.ReadLine();
        }

        public override void StartEngine()
        {
            Console.WriteLine("The car starts, much like cars are prone to do");
        }

        public override string ToString()
        {
            return color + " " + base.ToString();
        }

        void ICleanable.Clean()
        {
            Console.WriteLine("Car is cleanable");
        }
    }
}
