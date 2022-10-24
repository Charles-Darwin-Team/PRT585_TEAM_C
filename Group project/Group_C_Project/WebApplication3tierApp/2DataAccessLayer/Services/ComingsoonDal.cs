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
    public class ComingsoonDal : IComingsoonDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public ComingsoonDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<ComingsoonModel> GetAll()
        {
            var result = _db.Comingsoons.ToList();

            var returnObject = new List<ComingsoonModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToComingsoonModel());
            }

            return returnObject;
        }

        public ComingsoonModel? GetById(int ComingsoonId)
        {
            var result = _db.Comingsoons.SingleOrDefault(x => x.Id == ComingsoonId);
            return result?.ToComingsoonModel();
        }


        public int CreateComingsoon(ComingsoonModel Comingsoon)
        {
            var newComingsoon = Comingsoon.ToComingsoon();
            _db.Comingsoons.Add(newComingsoon);
            _db.SaveChanges();
            return newComingsoon.Id;
        }


        public void UpdateComingsoon(ComingsoonModel Comingsoon)
        {
            var existingComingsoon = _db.Comingsoons
                .SingleOrDefault(x => x.Id == Comingsoon.Id);

            if (existingComingsoon == null)
            {
                throw new ApplicationException($"Comingsoon {Comingsoon.Id} does not exist.");
            }
            Comingsoon.ToComingsoon(existingComingsoon);

            _db.Update(existingComingsoon);
            _db.SaveChanges();
        }

        public void DeleteComingsoon(int ComingsoonId)
        {
            var efModel = _db.Comingsoons.Find(ComingsoonId);
            _db.Comingsoons.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
