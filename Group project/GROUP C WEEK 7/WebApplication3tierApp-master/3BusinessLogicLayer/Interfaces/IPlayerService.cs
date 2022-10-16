using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IPlayerService
    {
        Task<PlayerModel?> GetById(int PlayerId);
        Task<List<PlayerModel>> GetAll();

        Task<int> CreatePlayer(PlayerModel Player);
        Task UpdatePlayer(PlayerModel Player);
        Task DeletePlayer(int PlayerId);
    }
}
