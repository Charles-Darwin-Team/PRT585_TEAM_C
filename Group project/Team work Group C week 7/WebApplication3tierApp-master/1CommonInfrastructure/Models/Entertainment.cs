using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class EntertainmentModel
    {
        public int EntertainmentId { get; set; } // int
        public string EntertainmentName { get; set; } // nvarchar(400)
        public string EntertainmentConfiguration { get; set; }
    }

}
