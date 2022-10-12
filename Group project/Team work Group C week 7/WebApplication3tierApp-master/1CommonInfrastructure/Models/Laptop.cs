using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class LaptopModel
    {
        public int LaptopId { get; set; } // int
        public string LaptopName { get; set; } // nvarchar(400)
        public string LaptopConfiguration { get; set; }
    }

}
