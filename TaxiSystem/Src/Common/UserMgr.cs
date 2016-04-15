using System.Collections.Generic;
using TaxiSystem.Database.MySQL;
using TaxiSystem.Object;

namespace TaxiSystem.Common
{
    internal class UserMgr
    {
        private static UserMgr _instance;
        private readonly List<User> _users;

        public UserMgr()
        {
            _users = new List<User>();
        }

        public static UserMgr Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserMgr();
                return _instance;
            }
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void RemoveUser(User user)
        {
            _users.Remove(user);
        }

        public void SaveAll()
        {
            var mysql = MySQL.Instance();
            mysql.BeginTransaction();

            foreach (var user in _users)
                user.SaveToDb(false);

            mysql.CommitTransaction();
        }

        public void Load()
        {

        }
    }
}
