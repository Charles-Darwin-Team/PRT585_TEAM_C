using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class ComingsoonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
                        
    }

    public static class ComingsoonDtoMapExtensions
    {
        public static ComingsoonDto ToComingsoonDto(this ComingsoonModel src)
        {
            var dst = new ComingsoonDto();
            dst.Id = src.Id;
            dst.Name = src.Name;            
            return dst;
        }

        public static ComingsoonModel ToComingsoonModel(this ComingsoonDto src)
        {
            var dst = new ComingsoonModel();
            dst.Id = src.Id;
            dst.Name = src.Name;            
            return dst;
        }
    }
}
