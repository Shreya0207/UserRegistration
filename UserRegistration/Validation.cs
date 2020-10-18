﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Validation
    {
        public static string NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";
        public bool ValidateName(string name)
        {
            return Regex.IsMatch(name, NAME_REGEX);
        }
    }
}