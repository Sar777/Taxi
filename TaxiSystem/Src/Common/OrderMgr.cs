using System.Collections.Generic;
using TaxiSystem.Src.Database.MySQL;

namespace TaxiSystem.Src.Common
{
    public class OrderMgr
    {
        private static OrderMgr instance;
        private List<Order> _orderings;

        private OrderMgr()
        {
            _orderings = new List<Order>();
        }

        public static OrderMgr Instance
        {
            get
            {
                if (instance == null)
                    instance = new OrderMgr();
                return instance;
            }
        }

        public void AddOrdering(Order ordering)
        {
            _orderings.Add(ordering);
        }

        public void RemoveOrdering(Order ordering)
        {
            _orderings.Remove(ordering);
        }

        public Order GetOrderingByID(int Id)
        {
            return _orderings.Find(x => x.ID == Id);
        }

        public int GetMaxOrderingID()
        {
            return _orderings.Count;
        }

        public void SaveAll()
        {
            MySQL mysql = MySQL.Instance();
            mysql.BeginTransaction();

            foreach (Order order in _orderings)
                order.SaveToDB(false);

            mysql.CommitTransaction();
        }
    }
}
