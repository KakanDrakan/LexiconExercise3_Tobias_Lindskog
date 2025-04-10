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
                    $"4: Add some pre-defined vehicles {Environment.NewLine}" +
                    $"5: Print error messages {Environment.NewLine}" +
                    $"6: Clear console");
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
                        VehicleHandler.AddPreDefinedVehicles();
                        break;
                    case "5":
                        SystemError.AddAndPrintErrors();
                        break;
                    case "6":
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
