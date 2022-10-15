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
    public static class VehicleMapExtensions
    {
        public static VehicleModel ToVehicleModel(this Vehicle src)
        {
            var dst = new VehicleModel();

            dst.VehicleId = src.VehicleId;
            dst.VehicleName = src.VehicleName;
            dst.VehicleColour = src.VehicleColour;

            return dst;
        }

        public static Vehicle ToVehicle(this VehicleModel src, Vehicle dst = null)
        {
            if (dst == null)
            {
                dst = new Vehicle();
            }

            dst.VehicleId = src.VehicleId;
            dst.VehicleName = src.VehicleName;
            dst.VehicleColour = src.VehicleColour;

            return dst;
        }
    }
}
