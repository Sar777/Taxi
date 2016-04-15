using System.Collections.Generic;
using TaxiSystem.Common;
using TaxiSystem.Database.MySQL;

namespace TaxiSystem.Src.Common
{
    public class OrderMgr
    {
        private static OrderMgr _instance;
        private readonly List<Order> _orderings;

        private OrderMgr()
        {
            _orderings = new List<Order>();
        }

        public static OrderMgr Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new OrderMgr();
                return _instance;
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

        public Order GetOrderingById(int id)
        {
            return _orderings.Find(x => x.Id == id);
        }

        public int GetMaxOrderingId()
        {
            return _orderings.Count;
        }

        public void SaveAll()
        {
            var mysql = MySQL.Instance();
            mysql.BeginTransaction();

            foreach (var order in _orderings)
                order.SaveToDb(false);

            mysql.CommitTransaction();
        }
    }
}
