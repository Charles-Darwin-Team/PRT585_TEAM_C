using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class CarDto
    {
        public int CarId { get; set; }
        public string Make { get; set; }
        public long Year { get; set; }
        public string Colour { get; set; }
    }

    public static class CarDtoMapExtensions
    {
        public static CarDto ToCarDto(this CarModel src)
        {
            var dst = new CarDto();
            dst.CarId = src.CarId;
            dst.Make = src.Make;
            dst.Year = src.Year;
            dst.Colour = src.Colour;
            return dst;
        }

        public static CarModel ToCarModel(this CarDto src)
        {
            var dst = new CarModel();
            dst.CarId = src.CarId;
            dst.Make = src.Make;
            dst.Year = src.Year;
            dst.Colour = src.Colour;
            return dst;
        }
    }
}
