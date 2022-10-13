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
    public class PhoneDal : IPhoneDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public PhoneDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<PhoneModel> GetAll()
        {
            var result = _db.Phones.ToList();

            var returnObject = new List<PhoneModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToPhoneModel());
            }

            return returnObject;
        }

        public PhoneModel? GetById(int PhoneId)
        {
            var result = _db.Phones.SingleOrDefault(x => x.PhoneId == PhoneId);
            return result?.ToPhoneModel();
        }


        public int CreatePhone(PhoneModel Phone)
        {
            var newPhone = Phone.ToPhone();
            _db.Phones.Add(newPhone);
            _db.SaveChanges();
            return newPhone.PhoneId;
        }


        public void UpdatePhone(PhoneModel Phone)
        {
            var existingPhone = _db.Phones
                .SingleOrDefault(x => x.PhoneId == Phone.PhoneId);

            if (existingPhone == null)
            {
                throw new ApplicationException($"Phone {Phone.PhoneId} does not exist.");
            }
            Phone.ToPhone(existingPhone);

            _db.Update(existingPhone);
            _db.SaveChanges();
        }

        public void DeletePhone(int PhoneId)
        {
            var efModel = _db.Phones.Find(PhoneId);
            _db.Phones.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
