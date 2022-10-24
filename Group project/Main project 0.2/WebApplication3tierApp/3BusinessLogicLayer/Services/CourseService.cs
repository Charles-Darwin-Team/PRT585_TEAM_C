

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class CourseService :  ICourseService
    {
        private readonly ICourseDal _CourseDal;
        //private readonly ICourseBalService _CourseBalService;
        public CourseService(ICourseDal CourseDal
        //ILoggingService loggingService,
        //ICourseDal CourseDal,
        //IAuditDal auditDal
       // ICourseBalanceService balsvc
        ) 
        {
            _CourseDal = CourseDal;
            // _CourseBalService = balsvc;
        }

        public async Task<CourseModel?> GetById(int Id)
        {           
            return _CourseDal.GetById(Id);
        }

        public async Task<List<CourseModel>> GetAll()
        {            
            return _CourseDal.GetAll();
        }

        public async Task<int> CreateCourse(CourseModel Course)
        {
            //write validations here
            var newId = _CourseDal.CreateCourse(Course);
            return newId;
        }

        public async Task UpdateCourse(CourseModel Course)
        {
            //write validations here 
            _CourseDal.UpdateCourse(Course);
        }

        public async Task DeleteCourse(int Id)
        {            
            try
            {
                //if(balservice.getBal(Id) = 0)
                _CourseDal.DeleteCourse(Id);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Course Id:{Id}. {e.Message}", e.StackTrace);
            }
        }
    }
}
