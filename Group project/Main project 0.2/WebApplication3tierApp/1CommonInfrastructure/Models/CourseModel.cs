using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class CourseModel
    {
        public int Id { get; set; } // int
        public string Name { get; set; } // nvarchar(400)
        public long Duration { get; set; }

    }

}
