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
    public static class PlayerMapExtensions
    {
        public static PlayerModel ToPlayerModel(this Player src)
        {
            var dst = new PlayerModel();

            dst.PlayerId = src.PlayerId;
            dst.PlayerName = src.PlayerName;

            return dst;
        }

        public static Player ToPlayer(this PlayerModel src, Player dst = null)
        {
            if (dst == null)
            {
                dst = new Player();
            }

            dst.PlayerId = src.PlayerId;
            dst.PlayerName = src.PlayerName;

            return dst;
        }
    }
}
