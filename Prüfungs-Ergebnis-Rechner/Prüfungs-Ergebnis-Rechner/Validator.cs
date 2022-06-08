using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Prüfungs_Ergebnis_Rechner
{
    public static class Validator
    {
        public static bool CheckInputToBeNummeric(string input)
        {
            Regex regex = new Regex("[^0-9]+");
            return regex.IsMatch(input);
        }

        public static bool CheckinputForWhitespace(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }
    }
}
