using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class VehicleDto
    {
        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
                        
    }

    public static class VehicleDtoMapExtensions
    {
        public static VehicleDto ToVehicleDto(this VehicleModel src)
        {
            var dst = new VehicleDto();
            dst.VehicleId = src.VehicleId;
            dst.VehicleName = src.VehicleName;            
            return dst;
        }

        public static VehicleModel ToVehicleModel(this VehicleDto src)
        {
            var dst = new VehicleModel();
            dst.VehicleId = src.VehicleId;
            dst.VehicleName = src.VehicleName;            
            return dst;
        }
    }
}
