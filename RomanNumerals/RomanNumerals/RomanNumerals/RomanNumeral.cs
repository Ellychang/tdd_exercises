using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumeral
    {

        public static string GetRomanNumerals(int input)
        {
            string output = "";
            var remaining = input;
            //if (input == 4)
            //{
            //    output = "IV";
            //    remaining -= input;
            //}
            //if (input == 9)
            //{
            //    output = "IX";
            //    remaining -= 9;
            //}

            AppendRomanNumerals(remaining, 9, "IX", ref output, ref remaining);
            AppendRomanNumerals(remaining, 5, "V", ref output, ref remaining);
            AppendRomanNumerals(remaining, 4, "IV", ref output, ref remaining);

            for (int i = 0; i < remaining; i++)
            {
                output += "I";
            }

            return output;
        }

        private static void AppendRomanNumerals(int input,int divBy, string romanNumberal,  ref string output, ref int remaining)
        {
            if (input >= divBy)
            {
                output = romanNumberal;
                remaining -= divBy;
            }
        }
    }
}
