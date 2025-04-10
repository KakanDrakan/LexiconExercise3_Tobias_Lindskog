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
        }

        public static void AddErrorTypesToList()
        {
            listOfErrors.Add(new EngineFailureError());
            listOfErrors.Add(new BrakeFailureError());
            listOfErrors.Add(new TransmissionError());
        }
    }
}
