using TaxiSystem.Auth;
using TaxiSystem.Database.MySQL;
using TaxiSystem.Src.Common;
using TaxiSystem.Users;

namespace TaxiSystem.Object
{
    public class User
    {
        public int Id { get; private set; }
        public string Username { get; private set; }

        public UserType UserTypeId { get; protected set; }

        public AuthToken Token { get; private set; }

        public User()
        {
            this.Id = 0;
            this.UserTypeId = UserType.USER_TYPE_UNKNOWN;
            this.Token = null;
            this.Username = "Unknown";
        }

        public User(int id, string username)
        {
            this.Id = id;
            this.Username = username;
            this.Token = null;
        }

        public User(string username)
        {
            this.Id = 0;
            this.Username = username;
            this.Token = null;
        }

        public User(int id, string username, AuthToken token)
        {
            this.Id = id;
            this.Username = username;
            this.Token = token;
        }

        public Client ToClient() { return this as Client; }
        public Manager ToManager() { return this as Manager; }
        public Driver ToDriver() { return this as Driver; }

        public virtual void SaveToDb(bool trans = true)
        {
            var mysql = MySQL.Instance();
            if (trans)
                mysql.BeginTransaction();

            mysql.PExecute(string.Format("DELETE FROM `users` WHERE `Id` = {0}", Id));
            mysql.PExecute(string.Format("INSERT INTO `users` (`Id`, `type`, `name`) VALUES ({0}, {1}, '{2}')", Id, (int)UserTypeId, Username));

            if (trans)
                mysql.CommitTransaction();
        }
    }
}
