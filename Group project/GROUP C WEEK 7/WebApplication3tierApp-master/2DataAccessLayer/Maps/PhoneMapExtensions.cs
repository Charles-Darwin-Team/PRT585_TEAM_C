using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Maps
{
    public static class PhoneMapExtensions
    {
        public static PhoneModel ToPhoneModel(this Phone src)
        {
            var dst = new PhoneModel();

            dst.PhoneId = src.PhoneId;
            dst.PhoneName = src.PhoneName;
            dst.PhoneMake = src.PhoneMake;

            return dst;
        }

        public static Phone ToPhone(this PhoneModel src, Phone dst = null)
        {
            if (dst == null)
            {
                dst = new Phone();
            }

            dst.PhoneId = src.PhoneId;
            dst.PhoneName = src.PhoneName;
            dst.PhoneMake = src.PhoneMake;

            return dst;
        }
    }
}
