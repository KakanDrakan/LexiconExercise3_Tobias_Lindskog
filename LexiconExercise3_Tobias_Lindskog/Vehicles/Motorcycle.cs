using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_Tobias_Lindskog.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        private bool hasSideCar;
        public bool HasSideCar { get; set; }

        public Motorcycle()
        {
            hasSideCar = false;
        }
        public override void SetUniqueTrait()
        {
            bool success = false;
            Console.Write("Does it have a side car? (yes/no): ");
            do
            {
                string input = Console.ReadLine();
                if (input == "yes")
                {
                    hasSideCar = true;
                    success = true;
                }
                else if (input == "no")
                {
                    hasSideCar = false;
                    success = true;
                }
            } while (!success);
        }

        public override void StartEngine()
        {
            Console.WriteLine("The motorcycle's engine is purring like a cat!");
        }

        public override string ToString()
        {
            if (HasSideCar) { return base.ToString() + " with side car"; }
            else { return base.ToString() + " without side car"; }
        }
    }
}
