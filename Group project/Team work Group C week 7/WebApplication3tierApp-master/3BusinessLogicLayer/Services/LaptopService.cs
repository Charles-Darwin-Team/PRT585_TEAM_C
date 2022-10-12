

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class LaptopService :  ILaptopService
    {
        private readonly ILaptopDal _LaptopDal;
        //private readonly ILaptopBalService _LaptopBalService;
        public LaptopService(ILaptopDal LaptopDal
        //ILoggingService loggingService,
        //ILaptopDal LaptopDal,
        //IAuditDal auditDal
       // ILaptopBalanceService balsvc
        ) 
        {
            _LaptopDal = LaptopDal;
            // _LaptopBalService = balsvc;
        }

        public async Task<LaptopModel?> GetById(int LaptopId)
        {           
            return _LaptopDal.GetById(LaptopId);
        }

        public async Task<List<LaptopModel>> GetAll()
        {            
            return _LaptopDal.GetAll();
        }

        public async Task<int> CreateLaptop(LaptopModel Laptop)
        {
            //write validations here
            var newLaptopId = _LaptopDal.CreateLaptop(Laptop);
            return newLaptopId;
        }

        public async Task UpdateLaptop(LaptopModel Laptop)
        {
            //write validations here 
            _LaptopDal.UpdateLaptop(Laptop);
        }

        public async Task DeleteLaptop(int LaptopId)
        {            
            try
            {
                //if(balservice.getBal(LaptopId) = 0)
                _LaptopDal.DeleteLaptop(LaptopId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Laptop Id:{LaptopId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
