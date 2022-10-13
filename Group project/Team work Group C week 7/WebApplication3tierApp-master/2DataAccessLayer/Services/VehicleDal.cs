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
    public class VehicleDal : IVehicleDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public VehicleDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<VehicleModel> GetAll()
        {
            var result = _db.Vehicles.ToList();

            var returnObject = new List<VehicleModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToVehicleModel());
            }

            return returnObject;
        }

        public VehicleModel? GetById(int VehicleId)
        {
            var result = _db.Vehicles.SingleOrDefault(x => x.VehicleId == VehicleId);
            return result?.ToVehicleModel();
        }


        public int CreateVehicle(VehicleModel Vehicle)
        {
            var newVehicle = Vehicle.ToVehicle();
            _db.Vehicles.Add(newVehicle);
            _db.SaveChanges();
            return newVehicle.VehicleId;
        }


        public void UpdateVehicle(VehicleModel Vehicle)
        {
            var existingVehicle = _db.Vehicles
                .SingleOrDefault(x => x.VehicleId == Vehicle.VehicleId);

            if (existingVehicle == null)
            {
                throw new ApplicationException($"Vehicle {Vehicle.VehicleId} does not exist.");
            }
            Vehicle.ToVehicle(existingVehicle);

            _db.Update(existingVehicle);
            _db.SaveChanges();
        }

        public void DeleteVehicle(int VehicleId)
        {
            var efModel = _db.Vehicles.Find(VehicleId);
            _db.Vehicles.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
