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
    public static class CarMapExtensions
    {
        public static CarModel ToCarModel(this Car src)
        {
            var dst = new CarModel();

            dst.CarId = src.CarId;
            dst.Make = src.Make;
            dst.Year = src.Year;
            dst.Colour = src.Colour;

            return dst;
        }

        public static Car ToCar(this CarModel src, Car dst = null)
        {
            if (dst == null)
            {
                dst = new Car();
            }

            dst.CarId = src.CarId;
            dst.Make = src.Make;
            dst.Year = src.Year;
            dst.Colour = src.Colour;

            return dst;
        }
    }
}
