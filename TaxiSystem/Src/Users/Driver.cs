using TaxiSystem.Auth;
using TaxiSystem.Database.MySQL;
using TaxiSystem.Object;
using TaxiSystem.RatingData;
using TaxiSystem.Src.Common;
using TaxiSystem.Src.Object;

namespace TaxiSystem.Users
{
    public class Driver : User
    {
        public Car Car { get; set; }
        public Rating Rating { get; set; }
        public DriverStatus Status { get; set; }

        public Driver() : base() { }

        public Driver(int id, string name, AuthToken token) : base(id, name, token)
        {
            UserTypeId = UserType.USER_TYPE_DRIVER;
            this.Status = DriverStatus.DRIVER_STATUS_NONE;
        }

        public override void SaveToDb(bool trans = true)
        {
            var mysql = MySQL.Instance();
            if (trans)
                mysql.BeginTransaction();

            base.SaveToDb(false);
            mysql.PExecute($"DELETE FROM `drivers` WHERE `Id` = {Id}");
            mysql.PExecute($"INSERT INTO `drivers` (`Id`, `status`, `cardId`) VALUES ({0}, {1}, {2})");

            if (trans)
                mysql.CommitTransaction();
        }
    }
}
