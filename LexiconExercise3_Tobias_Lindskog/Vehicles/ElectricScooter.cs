using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_Tobias_Lindskog.Vehicles
{
    internal class ElectricScooter: Vehicle
    {
        private int batteryRange;
        public int BatteryRange { get; set; }
        public ElectricScooter()
        {
            batteryRange = 100;
        }

        public override void SetUniqueTrait()
        {
            Console.Write("Battery range: ");
            bool success = false;
            do
            {
                if (int.TryParse(Console.ReadLine(), out batteryRange)) success = true;
                else Console.Write("must be a number: ");
            } while (!success);
        }

        public override void StartEngine()
        {
            Console.WriteLine("The electric scooter starts scooting scootily");
        }
        public override string ToString()
        {
            return base.ToString() + $" with battery range {batteryRange}km";
        }
    }
}
