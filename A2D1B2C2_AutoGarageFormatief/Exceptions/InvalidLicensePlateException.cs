using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2D1B2C2_AutoGarageFormatief.Exceptions
{
    public class InvalidLicensePlateException : Exception
    {
        public InvalidLicensePlateException() : base("Invalid licenseplate!")
        {
        }
    }
}
