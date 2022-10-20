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
    public static class MovieMapExtensions
    {
        public static MovieModel ToMovieModel(this Movie src)
        {
            var dst = new MovieModel();

            dst.Id = src.Id;
            dst.Name = src.Name;

            return dst;
        }

        public static Movie ToMovie(this MovieModel src, Movie dst = null)
        {
            if (dst == null)
            {
                dst = new Movie();
            }

            dst.Id = src.Id;
            dst.Name = src.Name;

            return dst;
        }
    }
}
