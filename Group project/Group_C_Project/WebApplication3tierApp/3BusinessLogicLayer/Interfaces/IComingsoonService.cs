using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IComingsoonService
    {
        Task<ComingsoonModel?> GetById(int ComingsoonId);
        Task<List<ComingsoonModel>> GetAll();

        Task<int> CreateComingsoon(ComingsoonModel Comingsoon);
        Task UpdateComingsoon(ComingsoonModel Comingsoon);
        Task DeleteComingsoon(int ComingsoonId);
    }
}
