using System;
using TaxiSystem.Src.Database.MySQL;
using TaxiSystem.Src.Users;

namespace TaxiSystem.Src.Common
{
    public class Order
    {
        public int ID { get; private set; }
        public Address ordAdress { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public CarType OrderType { get; set; }
        public Driver Driver { get; set; }

        public Order()
        {
            this.ID = 0;
            this.Status = OrderStatus.ORDERING_STATUS_NONE;
            this.OrderType = CarType.CAR_TYPE_NONE;
            this.Driver = null;
        }
 
        public Order(CarType carType, Address ordAdress, DateTime date)
        {
            this.ID = OrderMgr.Instance.GetMaxOrderingID() + 1;
            this.ordAdress = ordAdress;
            this.Date = date;
            this.Status = OrderStatus.ORDERING_STATUS_QUEUE;
            this.OrderType = carType;
            this.Driver = null;
        }

        public void SaveToDB(bool trans = true)
        {
            MySQL mysql = MySQL.Instance();

            if (trans)
                mysql.BeginTransaction();

            mysql.PExecute(string.Format("DELETE FROM `orders` WHERE `Id` = {0}", ID));
            mysql.PExecute(string.Format("INSERT INTO `orders` (`Id`, `type`, `status`, `date`, `address`, `driverId`) VALUES ({0}, {1}, {2}, {3}, {4}, {5})", ID, OrderType, Status, Date, ordAdress.ToString(), Driver != null ? Driver.ID : 0));

            if (trans)
                mysql.CommitTransaction();
        }
    }
}
