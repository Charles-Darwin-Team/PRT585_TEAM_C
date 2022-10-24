

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class StudentService :  IStudentService
    {
        private readonly IStudentDal _StudentDal;
        //private readonly IStudentBalService _StudentBalService;
        public StudentService(IStudentDal StudentDal
        //ILoggingService loggingService,
        //IStudentDal StudentDal,
        //IAuditDal auditDal
       // IStudentBalanceService balsvc
        ) 
        {
            _StudentDal = StudentDal;
            // _StudentBalService = balsvc;
        }

        public async Task<StudentModel?> GetById(int Id)
        {           
            return _StudentDal.GetById(Id);
        }

        public async Task<List<StudentModel>> GetAll()
        {            
            return _StudentDal.GetAll();
        }

        public async Task<int> CreateStudent(StudentModel Student)
        {
            //write validations here
            var newId = _StudentDal.CreateStudent(Student);
            return newId;
        }

        public async Task UpdateStudent(StudentModel Student)
        {
            //write validations here 
            _StudentDal.UpdateStudent(Student);
        }

        public async Task DeleteStudent(int Id)
        {            
            try
            {
                //if(balservice.getBal(Id) = 0)
                _StudentDal.DeleteStudent(Id);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Student Id:{Id}. {e.Message}", e.StackTrace);
            }
        }
    }
}
