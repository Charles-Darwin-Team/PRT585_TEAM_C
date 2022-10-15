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
    public static class LaptopMapExtensions
    {
        public static LaptopModel ToLaptopModel(this Laptop src)
        {
            var dst = new LaptopModel();

            dst.LaptopId = src.LaptopId;
            dst.LaptopName = src.LaptopName;
            dst.LaptopConfiguration = src.LaptopConfiguration;

            return dst;
        }

        public static Laptop ToLaptop(this LaptopModel src, Laptop dst = null)
        {
            if (dst == null)
            {
                dst = new Laptop();
            }

            dst.LaptopId = src.LaptopId;
            dst.LaptopName = src.LaptopName;
            dst.LaptopConfiguration = src.LaptopConfiguration;

            return dst;
        }
    }
}
