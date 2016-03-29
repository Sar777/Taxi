using System.Collections.Generic;
using TaxiSystem.Src.Database.MySQL;
using TaxiSystem.Src.Object;
using TaxiSystem.Src.Users;

namespace TaxiSystem.Src.Common
{
    class UserMgr
    {
        private static UserMgr instance;
        private List<User> _users;

        public UserMgr()
        {
            _users = new List<User>();
        }

        public static UserMgr Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserMgr();
                return instance;
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
            MySQL mysql = MySQL.Instance();
            mysql.BeginTransaction();

            foreach (User user in _users)
                user.SaveToDB(false);

            mysql.CommitTransaction();
        }

        public void Load()
        {

        }
    }
}
