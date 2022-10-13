using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IPhoneService
    {
        Task<PhoneModel?> GetById(int PhoneId);
        Task<List<PhoneModel>> GetAll();

        Task<int> CreatePhone(PhoneModel Phone);
        Task UpdatePhone(PhoneModel Phone);
        Task DeletePhone(int PhoneId);
    }
}
