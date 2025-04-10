using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_Tobias_Lindskog.Vehicles
{
    internal abstract class Vehicle
    {
        private string brand;
        private string model;
        private int year;
        private double weight;

        public string Brand
        {
            get { return brand; }
            set
            {
                if (isStringRightSize(value, 2, 20)) brand = value;
            }
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (isStringRightSize(value, 2, 20)) model = value;
            }
        }

        public int Year 
        { 
            get { return year; } 
            set 
            {
                if (value >= 1886 && value <= DateTime.Now.Year) year = value;
                else throw new ArgumentException("Error: Year must be between 1886 and current year");
            } 
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0) weight = value;
                else throw new ArgumentException("Error: Weight must be a positive number");
            }
        }

        static internal bool isStringRightSize(string word, int lowest, int highest)
        {
            if (word.Length >= lowest && word.Length <= highest) return true;
            else
            {
                throw new ArgumentException("Error: Brand and model must be between 2 and 20 characters long");
            }       
        }

        public override string ToString()
        {
            return $"{brand} {model}, {year}, weighing {weight}kg";
        }

        public abstract void StartEngine();

        public void Stats()
        {
            Console.WriteLine(this.ToString());
        }

        public abstract void SetUniqueTrait();
    }
}
