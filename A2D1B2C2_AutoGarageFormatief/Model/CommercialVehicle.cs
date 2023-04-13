using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2D1B2C2_AutoGarageFormatief.Model
{
    public class CommercialVehicle : Vehicle
    {
        public CommercialVehicle(int id, string licensePlate) : base(id, licensePlate)
        {
        }

        public int TowingWeight { get; set; }
    }
}
