using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface ILaptopDal
    {
        // Getters
        LaptopModel? GetById(int LaptopId);
        List<LaptopModel> GetAll();

        // Actions
        int CreateLaptop(LaptopModel Laptop);
        void UpdateLaptop(LaptopModel Laptop);
        void DeleteLaptop(int LaptopId);
    }
}
