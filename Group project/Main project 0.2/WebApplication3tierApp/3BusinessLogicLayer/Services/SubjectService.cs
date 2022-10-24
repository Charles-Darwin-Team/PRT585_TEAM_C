

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class SubjectService :  ISubjectService
    {
        private readonly ISubjectDal _SubjectDal;
        //private readonly ISubjectBalService _SubjectBalService;
        public SubjectService(ISubjectDal SubjectDal
        //ILoggingService loggingService,
        //ISubjectDal SubjectDal,
        //IAuditDal auditDal
       // ISubjectBalanceService balsvc
        ) 
        {
            _SubjectDal = SubjectDal;
            // _SubjectBalService = balsvc;
        }

        public async Task<SubjectModel?> GetById(int Id)
        {           
            return _SubjectDal.GetById(Id);
        }

        public async Task<List<SubjectModel>> GetAll()
        {            
            return _SubjectDal.GetAll();
        }

        public async Task<int> CreateSubject(SubjectModel Subject)
        {
            //write validations here
            var newId = _SubjectDal.CreateSubject(Subject);
            return newId;
        }

        public async Task UpdateSubject(SubjectModel Subject)
        {
            //write validations here 
            _SubjectDal.UpdateSubject(Subject);
        }

        public async Task DeleteSubject(int Id)
        {            
            try
            {
                //if(balservice.getBal(Id) = 0)
                _SubjectDal.DeleteSubject(Id);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Subject Id:{Id}. {e.Message}", e.StackTrace);
            }
        }
    }
}
