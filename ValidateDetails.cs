using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProgram
{
    class ValidateDetails
    {
        public Boolean FirstNameValidation(string fname)
        {
            Regex regex = new Regex("^[A-Z][a-z]{2,}$");
            if (regex.IsMatch(fname))
                return true;
            else
                return false;
        }
    }
}
