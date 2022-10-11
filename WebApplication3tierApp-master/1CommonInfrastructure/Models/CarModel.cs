using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class CarModel
    {
        public int CarId { get; set; } // int
        public string Make { get; set; } // nvarchar(400)
        public long Year { get; set; }
        public string Colour { get; set; }


    }

}
