using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToSpokenWords
{
    internal class NumberConverter
    {
        private static string[] units = {
            "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"
        };

        private static string[] teens = {
            "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };

        private static string[] tens = {
            "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
        };

        public static string ConvertToWords(int number)
        {
            if (number < 0 || number > 9999)
            {
                return "Number out of range or negative";
            }

            if (number < 10)
            {
                return units[number];
            }
            else if (number < 20)
            {
                return teens[number - 10];
            }
            else if (number < 100)
            {
                return tens[number / 10] + ((number % 10 != 0) ? " " + units[number % 10] : "");
            }
            else if (number < 1000)
            {
                return units[number / 100] + " Hundred" + ((number % 100 != 0) ? " and " + ConvertToWords(number % 100) : "");
            }
            else
            {
                return units[number / 1000] + " Thousand" + ((number % 1000 != 0) ? " " + ConvertToWords(number % 1000) : "");
            }
        }
    }     
}
