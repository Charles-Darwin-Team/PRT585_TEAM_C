using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class PhoneModel
    {
        public int PhoneId { get; set; } // int
        public string PhoneName { get; set; } // nvarchar(400)

        public string PhoneMake { get; set; }

    }

}
