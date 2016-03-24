
using TaxiSystem.Src.Common;
using TaxiSystem.Src.Object;
using TaxiSystem.Src.RatingData;

namespace TaxiSystem.Src.Users
{
    public class Driver : User
    {
        public Car Car { get; set; }
        public Rating Rating { get; set; }
        public DriverStatus Status { get; set; }

        public Driver() : base()
        {
            UserTypeId = UserType.USER_TYPE_DRIVER;
            this.Status = DriverStatus.DRIVER_STATUS_NONE;
        }
    }
}
