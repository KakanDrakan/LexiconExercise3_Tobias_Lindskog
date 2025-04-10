using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_Tobias_Lindskog.Vehicles
{
    internal class Truck : Vehicle, ICleanable
    {
        private int cargoCapacity; //car no go capacity. car go road
        public int CargoCapacity { get; set; }
        public Truck()
        {
            cargoCapacity = 20;
        }

        public override void SetUniqueTrait()
        {
            Console.Write("Cargo capacity: ");
            bool success = false;
            do
            {
                if (int.TryParse(Console.ReadLine(), out cargoCapacity)) success = true;
                else Console.Write("must be a number: ");
            } while (!success);
        }

        public override void StartEngine()
        {
            Console.WriteLine("The truck's engine, for what it's worth, tries its best");
        }
        public override string ToString()
        {
            return base.ToString() + $" with cargo capacity of {cargoCapacity}m²";
        }

        public void Clean()
        {
            Console.WriteLine("Truck is cleanable");
        }
    }
}
