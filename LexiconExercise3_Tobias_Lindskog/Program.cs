using LexiconExercise3_Tobias_Lindskog.SystemErrors;
using LexiconExercise3_Tobias_Lindskog.Vehicles;

namespace LexiconExercise3_Tobias_Lindskog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MainMenu();
                /*p.CreateVehicle(VehicleType.Car ,"Carbrand", "420", 1900, 1500);
                p.CreateVehicle(VehicleType.Truck, "TrucksAB", "AB123", 2001, 5000);
                p.CreateVehicle(VehicleType.Motorcycle, "MotorCAB", "motorcycleModel1", 2020, 142);
                p.CreateVehicle(VehicleType.ElectricScooter, "Electropop", "WeScootin", 1951, 30);*/
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public static void MainMenu()
        {
            bool isAlive = true;
            do
            {
                Console.WriteLine("You're in the main menu. Navigate by typing numbers:");
                Console.WriteLine($"0. Quit application {Environment.NewLine}" +
                    $"1. Add vehicle {Environment.NewLine}" +
                    $"2: List all vehicles {Environment.NewLine}" +
                    $"3: Remove all vehicles from list {Environment.NewLine}" +
                    $"4: Clear console");
                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "0":
                        isAlive = false;
                        break;
                    case "1":
                        VehicleHandler.UserCreateVehicle();
                        break;
                    case "2":
                        VehicleHandler.PrintAllVehicles();
                        break;
                    case "3":
                        VehicleHandler.ClearListOfVehicles();
                        break;
                    case "4":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again");
                        break;


                }
            } while (isAlive);
        }
    }
}
