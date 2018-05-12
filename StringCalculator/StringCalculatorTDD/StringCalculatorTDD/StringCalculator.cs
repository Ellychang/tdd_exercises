using System;
using System.Linq;

namespace StringCalculatorTDD
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            var stringToArray = numbers;
            if (numbers.Contains("\n"))
            {
                stringToArray = numbers.Replace('\n', ',');
            }
            var arrayOfStrings = stringToArray.Split(',');

            int total = 0;
            if (arrayOfStrings[0].Trim() == "") return total;
            foreach (string numbersString in arrayOfStrings)
            {
                var numberToAdd = int.Parse(numbersString.Trim());
                if (numberToAdd < 0) throw new Exception("Negative is not allowed.");
                total += int.Parse(numbersString.Trim());
            }

            return total;
        }
    }
}