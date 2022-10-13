

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class PhoneService :  IPhoneService
    {
        private readonly IPhoneDal _PhoneDal;
        //private readonly IPhoneBalService _PhoneBalService;
        public PhoneService(IPhoneDal PhoneDal
        //ILoggingService loggingService,
        //IPhoneDal PhoneDal,
        //IAuditDal auditDal
       // IPhoneBalanceService balsvc
        ) 
        {
            _PhoneDal = PhoneDal;
            // _PhoneBalService = balsvc;
        }

        public async Task<PhoneModel?> GetById(int PhoneId)
        {           
            return _PhoneDal.GetById(PhoneId);
        }

        public async Task<List<PhoneModel>> GetAll()
        {            
            return _PhoneDal.GetAll();
        }

        public async Task<int> CreatePhone(PhoneModel Phone)
        {
            //write validations here
            var newPhoneId = _PhoneDal.CreatePhone(Phone);
            return newPhoneId;
        }

        public async Task UpdatePhone(PhoneModel Phone)
        {
            //write validations here 
            _PhoneDal.UpdatePhone(Phone);
        }

        public async Task DeletePhone(int PhoneId)
        {            
            try
            {
                //if(balservice.getBal(PhoneId) = 0)
                _PhoneDal.DeletePhone(PhoneId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Phone Id:{PhoneId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
