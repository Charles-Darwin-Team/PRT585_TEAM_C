using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IVehicleDal
    {
        // Getters
        VehicleModel? GetById(int VehicleId);
        List<VehicleModel> GetAll();

        // Actions
        int CreateVehicle(VehicleModel Vehicle);
        void UpdateVehicle(VehicleModel Vehicle);
        void DeleteVehicle(int VehicleId);
    }
}
