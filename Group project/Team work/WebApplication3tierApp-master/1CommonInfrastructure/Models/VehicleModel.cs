using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class VehicleModel
    {
        public int VehicleId { get; set; } // int
        public string VehicleName { get; set; } // nvarchar(400)

        public string VehicleColour { get; set; }

    }

}
