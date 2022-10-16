using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface ISportService
    {
        Task<SportModel?> GetById(int SportId);
        Task<List<SportModel>> GetAll();

        Task<int> CreateSport(SportModel Sport);
        Task UpdateSport(SportModel Sport);
        Task DeleteSport(int SportId);
    }
}
