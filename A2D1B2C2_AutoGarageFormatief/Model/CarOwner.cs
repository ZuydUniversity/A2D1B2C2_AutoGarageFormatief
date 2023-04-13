using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2D1B2C2_AutoGarageFormatief.Model
{
    /// <summary>
    /// Owner of a vehicle
    /// </summary>
    public class CarOwner
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of the owner
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public CarOwner(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
