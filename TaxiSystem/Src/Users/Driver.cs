using TaxiSystem.Src.Auth;
using TaxiSystem.Src.Common;
using TaxiSystem.Src.Database.MySQL;
using TaxiSystem.Src.Object;
using TaxiSystem.Src.RatingData;

namespace TaxiSystem.Src.Users
{
    public class Driver : User
    {
        public Car Car { get; set; }
        public Rating Rating { get; set; }
        public DriverStatus Status { get; set; }

        public Driver(int Id, string name, AuthToken token) : base(Id, name, token)
        {
            UserTypeId = UserType.USER_TYPE_DRIVER;
            this.Status = DriverStatus.DRIVER_STATUS_NONE;
        }

        public override void SaveToDB(bool trans = true)
        {
            MySQL mysql = MySQL.Instance();
            if (trans)
                mysql.BeginTransaction();

            mysql.PExecute(string.Format("DELETE FROM `cars` WHERE `Id` = {0}", ID));
            mysql.PExecute(string.Format("INSERT INTO `cars` (`Id`, `status`, `cardId`) VALUES ({0}, {1}, {2})", ID, Status, Car.ID));

            if (trans)
                mysql.CommitTransaction();
        }
    }
}
