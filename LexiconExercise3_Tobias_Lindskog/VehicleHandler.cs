using LexiconExercise3_Tobias_Lindskog.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_Tobias_Lindskog
{
    internal class VehicleHandler
    {
        private static List<Vehicle> listOfVehicleInstances = new List<Vehicle>();

        public static Vehicle CreateVehicle(VehicleType type, string brand, string model, int year, int weight)
        {
            Vehicle vehicle;
            switch (type)
            {
                case VehicleType.Car: vehicle = new Car(); break;
                case VehicleType.ElectricScooter: vehicle = new ElectricScooter(); break;
                case VehicleType.Motorcycle: vehicle = new Motorcycle(); break;
                case VehicleType.Truck: vehicle = new Truck(); break;
                default: throw new ArgumentException("Unknown vehicle type");
            }

            vehicle.Brand = brand;
            vehicle.Model = model;
            vehicle.Year = year;
            vehicle.Weight = weight;

            listOfVehicleInstances.Add(vehicle);
            return vehicle;
        }

        public void SetBrand(Vehicle vehicle, string brand) 
        {
            vehicle.Brand = brand;
        }

        public void SetModel(Vehicle vehicle, string model)
        {
            vehicle.Model = model;
        }

        public void SetYear(Vehicle vehicle, int year)
        {
            vehicle.Year = year;
        }
        public void SetWeight(Vehicle vehicle, int weight)
        {
            vehicle.Weight = weight;
        }

        public static void PrintAllVehicles()
        {
            foreach (Vehicle vehicle in listOfVehicleInstances)
            {
                Console.WriteLine(vehicle.ToString());
                vehicle.StartEngine();
                if (vehicle is ICleanable cleanable) cleanable.Clean();
                Console.WriteLine();
            }
        }

        public static void ClearListOfVehicles()
        {
            listOfVehicleInstances.Clear();
        }

        public static Vehicle UserCreateVehicle()
        {
            Vehicle vehicle = GetVehicleTypeFromUserInput();
            vehicle.Brand = AskForString("Brand");
            vehicle.Model = AskForString("Model");
            vehicle.Year = AskForInt("Year");
            vehicle.Weight = AskForInt("Weight");
            vehicle.SetUniqueTrait();
            Console.Write("Added: ");
            vehicle.Stats();
            Console.WriteLine();
            listOfVehicleInstances.Add(vehicle);
            return vehicle;
        }
        private static Vehicle GetVehicleTypeFromUserInput()
        {
            bool success = false;
            VehicleType[] types = (VehicleType[])Enum.GetValues(typeof(VehicleType));
            Console.WriteLine("Choose a vehicle type:");
            for (int i = 0; i < types.Length; i++)
            {
                Console.WriteLine($"{i+1}. {types[i]}");
            }
            do
            {
                string input = Console.ReadLine();
                input.Trim();
                if (int.TryParse(input, out int inputAsInt))
                    switch(input)
                    {
                        case "1": return new Car();
                        case "2": return new Truck();
                        case "3": return new Motorcycle();
                        case "4": return new ElectricScooter();
                        default: throw new ArgumentException("Error: Invalid number was selected when selecting vehicle type");
                    }
                
            } while (!success);
            return new Car();
        }

        private static string AskForString(string itemAskedFor)
        {
            Console.Write($"{itemAskedFor}: ");
            return Console.ReadLine();
        }
        private static int AskForInt(string itemAskedFor)
        {
            bool success = false;
            int inputAsInt = 0;
            Console.Write($"{itemAskedFor}: ");
            do
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out inputAsInt))
                {
                    success = true;
                }
            } while (!success);
            return inputAsInt;
        }
    }
}
