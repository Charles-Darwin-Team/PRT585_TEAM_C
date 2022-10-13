using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; } // int
        public string VehicleName { get; set; } // nvarchar(400)
        public string VehicleColour { get; set; }
    }
}
