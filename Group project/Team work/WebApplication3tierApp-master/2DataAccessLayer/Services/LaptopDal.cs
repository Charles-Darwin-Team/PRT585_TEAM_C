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
    public class LaptopDal : ILaptopDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public LaptopDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<LaptopModel> GetAll()
        {
            var result = _db.Laptops.ToList();

            var returnObject = new List<LaptopModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToLaptopModel());
            }

            return returnObject;
        }

        public LaptopModel? GetById(int LaptopId)
        {
            var result = _db.Laptops.SingleOrDefault(x => x.LaptopId == LaptopId);
            return result?.ToLaptopModel();
        }


        public int CreateLaptop(LaptopModel Laptop)
        {
            var newLaptop = Laptop.ToLaptop();
            _db.Laptops.Add(newLaptop);
            _db.SaveChanges();
            return newLaptop.LaptopId;
        }


        public void UpdateLaptop(LaptopModel Laptop)
        {
            var existingLaptop = _db.Laptops
                .SingleOrDefault(x => x.LaptopId == Laptop.LaptopId);

            if (existingLaptop == null)
            {
                throw new ApplicationException($"Laptop {Laptop.LaptopId} does not exist.");
            }
            Laptop.ToLaptop(existingLaptop);

            _db.Update(existingLaptop);
            _db.SaveChanges();
        }

        public void DeleteLaptop(int LaptopId)
        {
            var efModel = _db.Laptops.Find(LaptopId);
            _db.Laptops.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
