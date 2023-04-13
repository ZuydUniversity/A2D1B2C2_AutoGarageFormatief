using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2D1B2C2_AutoGarageFormatief.Model
{
    public class CarOwner
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CarOwner(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
