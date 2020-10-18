﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Validation
    {
        public static string MOBILE_REGEX = "^[1-9]{1}[0-9]{1,2}[ ][1-9]{1}[0-9]{9}$";
        public bool ValidateMobileNumber(string name)
        {
            return Regex.IsMatch(name, MOBILE_REGEX);
        }
    }
}
