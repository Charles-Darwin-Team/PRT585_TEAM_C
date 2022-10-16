using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class SportDto
    {
        public int SportId { get; set; }
        public string SportName { get; set; }

        public int YearOfPublication { get; set; }

    }

    public static class SportDtoMapExtensions
    {
        public static SportDto ToSportDto(this SportModel src)
        {
            var dst = new SportDto();
            dst.SportId = src.SportId;
            dst.SportName = src.SportName;
            
            return dst;
        }

        public static SportModel ToSportModel(this SportDto src)
        {
            var dst = new SportModel();
            dst.SportId = src.SportId;
            dst.SportName = src.SportName;
            

            return dst;
        }
    }
}
