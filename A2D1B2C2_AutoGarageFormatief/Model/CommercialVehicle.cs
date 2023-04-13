using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2D1B2C2_AutoGarageFormatief.Model
{
    /// <summary>
    /// Commercial vehicle class
    /// </summary>
    public class CommercialVehicle : Vehicle
    {
        /// <summary>
        /// Towing weight of the vehicle
        /// </summary>
        public int TowingWeight { get; set; }

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="id"Id of the vehicle></param>
        /// <param name="licensePlate">Licenseplate</param>
        /// <param name="towingWeight">The towing weight</param>
        public CommercialVehicle(int id, string licensePlate, int towingWeight) : base(id, licensePlate)
        {
        }
    }
}
