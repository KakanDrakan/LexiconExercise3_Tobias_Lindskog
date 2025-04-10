using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise3_Tobias_Lindskog.SystemErrors
{
    internal class BrakeFailureError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Brake failure: Vehicle is unsafe to drive!";
        }
    }
}
