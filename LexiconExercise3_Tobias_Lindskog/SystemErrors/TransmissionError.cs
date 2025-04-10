using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_Tobias_Lindskog.SystemErrors
{
    internal class TransmissionError: SystemError
    {
        public override string ErrorMessage()
        {
            return "Transmission error: Repairs required!";
        }
    }
}
