using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2D1B2C2_AutoGarageFormatief.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string? Description{ get; set; }
        public string LicensePlate { get; set; }

        public Vehicle(int id, string licensePlate)
        {
            Id = id;
            LicensePlate = licensePlate ?? string.Empty;
        }
    }
}
