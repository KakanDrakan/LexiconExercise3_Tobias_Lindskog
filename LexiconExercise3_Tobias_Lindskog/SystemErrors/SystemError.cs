using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_Tobias_Lindskog.SystemErrors
{
    abstract class SystemError
    {
        static List<SystemError> listOfErrors = new List<SystemError>();
        protected SystemError()
        {
            listOfErrors.Add(this);
        }
        
        public abstract string ErrorMessage();

        public static void PrintAllErrorMessages()
        {
            foreach (var error in listOfErrors)
            {
                Console.WriteLine(error.ErrorMessage());
            }
            Console.WriteLine();
        }

        public static void AddAndPrintErrors()
        {
            new EngineFailureError();
            new BrakeFailureError();
            new TransmissionError();
            PrintAllErrorMessages();
        }
    }
}
