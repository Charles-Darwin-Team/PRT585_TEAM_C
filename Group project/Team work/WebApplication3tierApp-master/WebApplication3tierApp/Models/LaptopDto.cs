using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class LaptopDto
    {
        public int LaptopId { get; set; }
        public string LaptopName { get; set; }

        public string LaptopConfiguration { get; set; }

    }

    public static class LaptopDtoMapExtensions
    {
        public static LaptopDto ToLaptopDto(this LaptopModel src)
        {
            var dst = new LaptopDto();
            dst.LaptopId = src.LaptopId;
            dst.LaptopName = src.LaptopName;
            dst.LaptopConfiguration = src.LaptopConfiguration;
            return dst;
        }

        public static LaptopModel ToLaptopModel(this LaptopDto src)
        {
            var dst = new LaptopModel();
            dst.LaptopId = src.LaptopId;
            dst.LaptopName = src.LaptopName;
            dst.LaptopConfiguration = src.LaptopConfiguration;

            return dst;
        }
    }
}
