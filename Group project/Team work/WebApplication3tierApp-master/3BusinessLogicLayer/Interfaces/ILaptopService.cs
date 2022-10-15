using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface ILaptopService
    {
        Task<LaptopModel?> GetById(int LaptopId);
        Task<List<LaptopModel>> GetAll();

        Task<int> CreateLaptop(LaptopModel Laptop);
        Task UpdateLaptop(LaptopModel Laptop);
        Task DeleteLaptop(int LaptopId);
    }
}
