using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kalkulator_jedno_dzialanie_if
{
    public static class Validator
    {

        public static bool IsInputValid(string FirstIn)
        {
            string pattern = @"^\d+$";
            return Regex.IsMatch(FirstIn, pattern);
        }

        private static bool checkNull(string FirstIn, string SecIn)
        {
            if (String.IsNullOrWhiteSpace(FirstIn.ToString()) && (String.IsNullOrWhiteSpace(SecIn.ToString())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool checkIfZero(string SecIn)
        {
            if (SecIn == "0")
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        

       

    }
}
