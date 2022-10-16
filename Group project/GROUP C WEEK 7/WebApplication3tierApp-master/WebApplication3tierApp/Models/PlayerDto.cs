using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class PlayerDto
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
                 
    }

    public static class PlayerDtoMapExtensions
    {
        public static PlayerDto ToPlayerDto(this PlayerModel src)
        {
            var dst = new PlayerDto();
            dst.PlayerId = src.PlayerId;
            dst.PlayerName = src.PlayerName;
                     
            return dst;
        }

        public static PlayerModel ToPlayerModel(this PlayerDto src)
        {
            var dst = new PlayerModel();
            dst.PlayerId = src.PlayerId;
            dst.PlayerName = src.PlayerName;
                      
            return dst;
        }
    }
}
