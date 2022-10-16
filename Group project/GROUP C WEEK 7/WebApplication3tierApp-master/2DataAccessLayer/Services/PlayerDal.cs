using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context;
using _2DataAccessLayer.Context.Models;
using _2DataAccessLayer.Interfaces;
using _2DataAccessLayer.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Services
{
    public class PlayerDal : IPlayerDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public PlayerDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<PlayerModel> GetAll()
        {
            var result = _db.Players.ToList();

            var returnObject = new List<PlayerModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToPlayerModel());
            }

            return returnObject;
        }

        public PlayerModel? GetById(int PlayerId)
        {
            var result = _db.Players.SingleOrDefault(x => x.PlayerId == PlayerId);
            return result?.ToPlayerModel();
        }


        public int CreatePlayer(PlayerModel Player)
        {
            var newPlayer = Player.ToPlayer();
            _db.Players.Add(newPlayer);
            _db.SaveChanges();
            return newPlayer.PlayerId;
        }


        public void UpdatePlayer(PlayerModel Player)
        {
            var existingPlayer = _db.Players
                .SingleOrDefault(x => x.PlayerId == Player.PlayerId);

            if (existingPlayer == null)
            {
                throw new ApplicationException($"Player {Player.PlayerId} does not exist.");
            }
            Player.ToPlayer(existingPlayer);

            _db.Update(existingPlayer);
            _db.SaveChanges();
        }

        public void DeletePlayer(int PlayerId)
        {
            var efModel = _db.Players.Find(PlayerId);
            _db.Players.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
