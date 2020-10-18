using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Validation
    {
        public static string PASSWORD4_REGEX = "^(?=.*[0-9])(?=.*[A-Z])(?=[^!@#$%&+-.]*[!@#$%&+-.][^!@#$%&+-.]*$)[\\S]{8,}$";
        public bool ValidatePassword(string name)
        {
            return Regex.IsMatch(name, PASSWORD4_REGEX);
        }
    }
}
