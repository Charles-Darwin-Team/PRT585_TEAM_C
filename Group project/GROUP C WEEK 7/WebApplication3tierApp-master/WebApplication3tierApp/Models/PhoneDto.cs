using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class PhoneDto
    {
        public int PhoneId { get; set; }
        public string PhoneName { get; set; }
        public string PhoneMake { get; set; }

    }

    public static class PhoneDtoMapExtensions
    {
        public static PhoneDto ToPhoneDto(this PhoneModel src)
        {
            var dst = new PhoneDto();
            dst.PhoneId = src.PhoneId;
            dst.PhoneName = src.PhoneName; 
            dst.PhoneMake = src.PhoneMake;
            return dst;
        }

        public static PhoneModel ToPhoneModel(this PhoneDto src)
        {
            var dst = new PhoneModel();
            dst.PhoneId = src.PhoneId;
            dst.PhoneName = src.PhoneName;
            dst.PhoneMake = src.PhoneMake;
            return dst;
        }
    }
}
