using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IPlayerDal
    {
        // Getters
        PlayerModel? GetById(int PlayerId);
        List<PlayerModel> GetAll();

        // Actions
        int CreatePlayer(PlayerModel Player);
        void UpdatePlayer(PlayerModel Player);
        void DeletePlayer(int PlayerId);
    }
}
