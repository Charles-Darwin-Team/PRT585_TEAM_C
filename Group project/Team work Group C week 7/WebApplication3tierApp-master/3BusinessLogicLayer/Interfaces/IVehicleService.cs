using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IVehicleService
    {
        Task<VehicleModel?> GetById(int VehicleId);
        Task<List<VehicleModel>> GetAll();

        Task<int> CreateVehicle(VehicleModel Vehicle);
        Task UpdateVehicle(VehicleModel Vehicle);
        Task DeleteVehicle(int VehicleId);
    }
}
