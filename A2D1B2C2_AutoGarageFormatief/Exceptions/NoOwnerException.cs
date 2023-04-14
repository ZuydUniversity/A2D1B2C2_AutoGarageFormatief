using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2D1B2C2_AutoGarageFormatief.Exceptions
{
    public class NoOwnerException : Exception
    {
        public NoOwnerException() : base("Vehicle has no owner!")
        {
            
        }
    }
}
