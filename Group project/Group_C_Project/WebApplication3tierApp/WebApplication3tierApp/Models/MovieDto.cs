using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
                        
    }

    public static class MovieDtoMapExtensions
    {
        public static MovieDto ToMovieDto(this MovieModel src)
        {
            var dst = new MovieDto();
            dst.Id = src.Id;
            dst.Name = src.Name;            
            return dst;
        }

        public static MovieModel ToMovieModel(this MovieDto src)
        {
            var dst = new MovieModel();
            dst.Id = src.Id;
            dst.Name = src.Name;            
            return dst;
        }
    }
}
