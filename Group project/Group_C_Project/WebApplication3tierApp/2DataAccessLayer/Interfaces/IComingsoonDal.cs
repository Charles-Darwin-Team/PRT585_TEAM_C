using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IComingsoonDal
    {
        // Getters
        ComingsoonModel? GetById(int ComingsoonId);
        List<ComingsoonModel> GetAll();

        // Actions
        int CreateComingsoon(ComingsoonModel Comingsoon);
        void UpdateComingsoon(ComingsoonModel Comingsoon);
        void DeleteComingsoon(int ComingsoonId);
    }
}
