using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Phone
    {
        public int PhoneId { get; set; } // int
        public string PhoneName { get; set; } // nvarchar(400)
        public string PhoneMake { get; set; }

    }
}
