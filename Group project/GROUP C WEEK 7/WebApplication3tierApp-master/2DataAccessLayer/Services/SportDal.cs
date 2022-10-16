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
    public class SportDal : ISportDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public SportDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<SportModel> GetAll()
        {
            var result = _db.Sports.ToList();

            var returnObject = new List<SportModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToSportModel());
            }

            return returnObject;
        }

        public SportModel? GetById(int SportId)
        {
            var result = _db.Sports.SingleOrDefault(x => x.SportId == SportId);
            return result?.ToSportModel();
        }


        public int CreateSport(SportModel Sport)
        {
            var newSport = Sport.ToSport();
            _db.Sports.Add(newSport);
            _db.SaveChanges();
            return newSport.SportId;
        }


        public void UpdateSport(SportModel Sport)
        {
            var existingSport = _db.Sports
                .SingleOrDefault(x => x.SportId == Sport.SportId);

            if (existingSport == null)
            {
                throw new ApplicationException($"Sport {Sport.SportId} does not exist.");
            }
            Sport.ToSport(existingSport);

            _db.Update(existingSport);
            _db.SaveChanges();
        }

        public void DeleteSport(int SportId)
        {
            var efModel = _db.Sports.Find(SportId);
            _db.Sports.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
