using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Maps
{
    public static class ComingsoonMapExtensions
    {
        public static ComingsoonModel ToComingsoonModel(this Comingsoon src)
        {
            var dst = new ComingsoonModel();

            dst.Id = src.Id;
            dst.Name = src.Name;

            return dst;
        }

        public static Comingsoon ToComingsoon(this ComingsoonModel src, Comingsoon dst = null)
        {
            if (dst == null)
            {
                dst = new Comingsoon();
            }

            dst.Id = src.Id;
            dst.Name = src.Name;

            return dst;
        }
    }
}
