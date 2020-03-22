using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Password
{
    public class PasswordValidator
    {
        public bool Validate(string input)
        {
            var symbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            if (input == null) return false;
            if (input.Length > 7 
                && input.Length <13
                && input.Count(char.IsUpper) >=1
                && input.Count(char.IsLower) >=1
                && symbols.IsMatch(input))
                return true;

            return false;
        }
    }
}
