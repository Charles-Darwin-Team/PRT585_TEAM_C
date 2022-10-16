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
    public static class SportMapExtensions
    {
        public static SportModel ToSportModel(this Sport src)
        {
            var dst = new SportModel();

            dst.SportId = src.SportId;
            dst.SportName = src.SportName;

            return dst;
        }

        public static Sport ToSport(this SportModel src, Sport dst = null)
        {
            if (dst == null)
            {
                dst = new Sport();
            }

            dst.SportId = src.SportId;
            dst.SportName = src.SportName;

            return dst;
        }
    }
}
