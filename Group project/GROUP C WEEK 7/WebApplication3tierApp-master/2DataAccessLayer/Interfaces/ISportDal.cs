using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface ISportDal
    {
        // Getters
        SportModel? GetById(int SportId);
        List<SportModel> GetAll();

        // Actions
        int CreateSport(SportModel Sport);
        void UpdateSport(SportModel Sport);
        void DeleteSport(int SportId);
    }
}
