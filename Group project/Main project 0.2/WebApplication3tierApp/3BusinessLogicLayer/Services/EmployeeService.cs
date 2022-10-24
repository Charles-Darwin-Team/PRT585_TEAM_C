

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class EmployeeService :  IEmployeeService
    {
        private readonly IEmployeeDal _EmployeeDal;
        //private readonly IEmployeeBalService _EmployeeBalService;
        public EmployeeService(IEmployeeDal EmployeeDal
        //ILoggingService loggingService,
        //IEmployeeDal EmployeeDal,
        //IAuditDal auditDal
       // IEmployeeBalanceService balsvc
        ) 
        {
            _EmployeeDal = EmployeeDal;
            // _EmployeeBalService = balsvc;
        }

        public async Task<EmployeeModel?> GetById(int Id)
        {           
            return _EmployeeDal.GetById(Id);
        }

        public async Task<List<EmployeeModel>> GetAll()
        {            
            return _EmployeeDal.GetAll();
        }

        public async Task<int> CreateEmployee(EmployeeModel Employee)
        {
            //write validations here
            var newId = _EmployeeDal.CreateEmployee(Employee);
            return newId;
        }

        public async Task UpdateEmployee(EmployeeModel Employee)
        {
            //write validations here 
            _EmployeeDal.UpdateEmployee(Employee);
        }

        public async Task DeleteEmployee(int Id)
        {            
            try
            {
                //if(balservice.getBal(Id) = 0)
                _EmployeeDal.DeleteEmployee(Id);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Employee Id:{Id}. {e.Message}", e.StackTrace);
            }
        }
    }
}
