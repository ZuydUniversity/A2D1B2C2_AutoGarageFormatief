using A2D1B2C2_AutoGarageFormatief.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2D1B2C2_AutoGarageFormatief.Model
{
    /// <summary>
    /// Vehicle (parent) class
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Description of the vehicle
        /// </summary>
        public string? Description{ get; set; }
        /// <summary>
        /// License plate of the vehicle
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// Owner of the car
        /// </summary>
        public CarOwner CarOwner { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="licensePlate"></param>
        public Vehicle(int id, string licensePlate, CarOwner carOwner)
        {
            Id = id;            
            LicensePlate = licensePlate ?? string.Empty;
            CarOwner = carOwner;
        }

        // data access

        /// <summary>
        /// Create vehicle in data layer
        /// </summary>
        public void CreateVehicleData()
        {
            new DALSQL().CreateVehicle(this);
        }

        /// <summary>
        /// Delete the vehicle from the data layer
        /// </summary>
        public void DeleteVehicleData()
        {
            new DALSQL().DeleteVehicle(this);
        }
    }
}
