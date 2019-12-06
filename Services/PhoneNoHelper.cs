using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudyPal.Services
{
    public static class PhoneNoHelper
    {
        public static bool ValidatePhoneNo(string telNo)
        {
            if((telNo.Length == 11) || (telNo.Length == 14))
            {
                return true;
            }
            return false;
        }
    }
}
