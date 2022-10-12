using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Laptop
    {
        public int LaptopId { get; set; } // int
        public string LaptopName { get; set; } // nvarchar(400)
        public string LaptopConfiguration { get; set; }
    }
}
