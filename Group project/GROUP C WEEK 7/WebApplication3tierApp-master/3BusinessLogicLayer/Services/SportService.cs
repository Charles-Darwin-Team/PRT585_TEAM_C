

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class SportService :  ISportService
    {
        private readonly ISportDal _SportDal;
        //private readonly ISportBalService _SportBalService;
        public SportService(ISportDal SportDal
        //ILoggingService loggingService,
        //ISportDal SportDal,
        //IAuditDal auditDal
       // ISportBalanceService balsvc
        ) 
        {
            _SportDal = SportDal;
            // _SportBalService = balsvc;
        }

        public async Task<SportModel?> GetById(int SportId)
        {           
            return _SportDal.GetById(SportId);
        }

        public async Task<List<SportModel>> GetAll()
        {            
            return _SportDal.GetAll();
        }

        public async Task<int> CreateSport(SportModel Sport)
        {
            //write validations here
            var newSportId = _SportDal.CreateSport(Sport);
            return newSportId;
        }

        public async Task UpdateSport(SportModel Sport)
        {
            //write validations here 
            _SportDal.UpdateSport(Sport);
        }

        public async Task DeleteSport(int SportId)
        {            
            try
            {
                //if(balservice.getBal(SportId) = 0)
                _SportDal.DeleteSport(SportId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Sport Id:{SportId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
