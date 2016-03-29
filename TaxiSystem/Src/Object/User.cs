using TaxiSystem.Src.Auth;
using TaxiSystem.Src.Common;
using TaxiSystem.Src.Database.MySQL;
using TaxiSystem.Src.Users;

namespace TaxiSystem.Src.Object
{
    public class User
    {
        public int ID { get; private set; }
        public string Username { get; private set; }

        public UserType UserTypeId { get; protected set; }

        public AuthToken Token { get; private set; }

        public User()
        {
            this.ID = 0;
            this.UserTypeId = UserType.USER_TYPE_UNKNOWN;
            this.Token = null;
        }

        public User(int id, string username)
        {
            this.ID = id;
            this.Username = username;
            this.Token = null;
        }

        public User(int id, string username, AuthToken token)
        {
            this.ID = id;
            this.Username = username;
            this.Token = token;
        }

        public Client ToClient() { return this as Client; }
        public Manager ToManager() { return this as Manager; }
        public Driver ToDriver() { return this as Driver; }

        virtual public void SaveToDB(bool trans = true)
        {
            MySQL mysql = MySQL.Instance();
            if (trans)
                mysql.BeginTransaction();

            mysql.PExecute(string.Format("DELETE FROM `users` WHERE `Id` = {0}", ID));
            mysql.PExecute(string.Format("INSERT INTO `users` (`Id`, `type`, `name`) VALUES ({0}, {1}, {2})", ID, UserTypeId, Username));

            switch (UserTypeId)
            {
                case UserType.USER_TYPE_DRIVER:
                    ToDriver().SaveToDB(false);
                    break;
                case UserType.USER_TYPE_CLIENT:
                case UserType.USER_TYPE_MANAGER:
                default:
                    System.Console.WriteLine("User::SaveToDB: User type {0} not supported.", UserTypeId.ToString());
                    break;
            }

            if (trans)
                mysql.CommitTransaction();
        }
    }
}
