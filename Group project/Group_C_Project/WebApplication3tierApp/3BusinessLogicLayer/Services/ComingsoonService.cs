

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class ComingsoonService :  IComingsoonService
    {
        private readonly IComingsoonDal _ComingsoonDal;
        //private readonly IComingsoonBalService _ComingsoonBalService;
        public ComingsoonService(IComingsoonDal ComingsoonDal
        //ILoggingService loggingService,
        //IComingsoonDal ComingsoonDal,
        //IAuditDal auditDal
       // IComingsoonBalanceService balsvc
        ) 
        {
            _ComingsoonDal = ComingsoonDal;
            // _ComingsoonBalService = balsvc;
        }

        public async Task<ComingsoonModel?> GetById(int ComingsoonId)
        {           
            return _ComingsoonDal.GetById(ComingsoonId);
        }

        public async Task<List<ComingsoonModel>> GetAll()
        {            
            return _ComingsoonDal.GetAll();
        }

        public async Task<int> CreateComingsoon(ComingsoonModel Comingsoon)
        {
            //write validations here
            var newComingsoonId = _ComingsoonDal.CreateComingsoon(Comingsoon);
            return newComingsoonId;
        }

        public async Task UpdateComingsoon(ComingsoonModel Comingsoon)
        {
            //write validations here 
            _ComingsoonDal.UpdateComingsoon(Comingsoon);
        }

        public async Task DeleteComingsoon(int ComingsoonId)
        {            
            try
            {
                //if(balservice.getBal(ComingsoonId) = 0)
                _ComingsoonDal.DeleteComingsoon(ComingsoonId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Comingsoon Id:{ComingsoonId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
