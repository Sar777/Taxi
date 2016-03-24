using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiSystem.Src.Common
{
    public class Order
    {
        public int ID { get; private set; }
        public Address ordAdress { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public CarType OrderType { get; set; }

        public Order()
        {
            this.ID = 0;
            this.Status = OrderStatus.ORDERING_STATUS_NONE;
            this.OrderType = CarType.CAR_TYPE_NONE;
        }
 
        public Order(CarType carType, Address ordAdress, DateTime date)
        {
            this.ID = OrderMgr.Instance.GetMaxOrderingID() + 1;
            this.ordAdress = ordAdress;
            this.Date = date;
            this.Status = OrderStatus.ORDERING_STATUS_QUEUE;
            this.OrderType = carType;
        }
    }
}
