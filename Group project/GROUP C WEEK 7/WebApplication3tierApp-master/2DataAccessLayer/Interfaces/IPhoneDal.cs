using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IPhoneDal
    {
        // Getters
        PhoneModel? GetById(int PhoneId);
        List<PhoneModel> GetAll();

        // Actions
        int CreatePhone(PhoneModel Phone);
        void UpdatePhone(PhoneModel Phone);
        void DeletePhone(int PhoneId);
    }
}
