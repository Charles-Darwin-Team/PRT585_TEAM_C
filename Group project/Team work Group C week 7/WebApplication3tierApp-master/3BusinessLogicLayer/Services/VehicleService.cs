

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class VehicleService :  IVehicleService
    {
        private readonly IVehicleDal _VehicleDal;
        //private readonly IVehicleBalService _VehicleBalService;
        public VehicleService(IVehicleDal VehicleDal
        //ILoggingService loggingService,
        //IVehicleDal VehicleDal,
        //IAuditDal auditDal
       // IVehicleBalanceService balsvc
        ) 
        {
            _VehicleDal = VehicleDal;
            // _VehicleBalService = balsvc;
        }

        public async Task<VehicleModel?> GetById(int VehicleId)
        {           
            return _VehicleDal.GetById(VehicleId);
        }

        public async Task<List<VehicleModel>> GetAll()
        {            
            return _VehicleDal.GetAll();
        }

        public async Task<int> CreateVehicle(VehicleModel Vehicle)
        {
            //write validations here
            var newVehicleId = _VehicleDal.CreateVehicle(Vehicle);
            return newVehicleId;
        }

        public async Task UpdateVehicle(VehicleModel Vehicle)
        {
            //write validations here 
            _VehicleDal.UpdateVehicle(Vehicle);
        }

        public async Task DeleteVehicle(int VehicleId)
        {            
            try
            {
                //if(balservice.getBal(VehicleId) = 0)
                _VehicleDal.DeleteVehicle(VehicleId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Vehicle Id:{VehicleId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
