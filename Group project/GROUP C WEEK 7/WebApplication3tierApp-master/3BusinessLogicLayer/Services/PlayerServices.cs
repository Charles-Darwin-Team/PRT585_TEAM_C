

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class PlayerService :  IPlayerService
    {
        private readonly IPlayerDal _PlayerDal;
        //private readonly IPlayerBalService _PlayerBalService;
        public PlayerService(IPlayerDal PlayerDal
        //ILoggingService loggingService,
        //IPlayerDal PlayerDal,
        //IAuditDal auditDal
       // IPlayerBalanceService balsvc
        ) 
        {
            _PlayerDal = PlayerDal;
            // _PlayerBalService = balsvc;
        }

        public async Task<PlayerModel?> GetById(int PlayerId)
        {           
            return _PlayerDal.GetById(PlayerId);
        }

        public async Task<List<PlayerModel>> GetAll()
        {            
            return _PlayerDal.GetAll();
        }

        public async Task<int> CreatePlayer(PlayerModel Player)
        {
            //write validations here
            var newPlayerId = _PlayerDal.CreatePlayer(Player);
            return newPlayerId;
        }

        public async Task UpdatePlayer(PlayerModel Player)
        {
            //write validations here 
            _PlayerDal.UpdatePlayer(Player);
        }

        public async Task DeletePlayer(int PlayerId)
        {            
            try
            {
                //if(balservice.getBal(PlayerId) = 0)
                _PlayerDal.DeletePlayer(PlayerId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Player Id:{PlayerId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
