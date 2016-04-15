using System;
using TaxiSystem.Common;
using TaxiSystem.Database.MySQL;
using TaxiSystem.Object;
using TaxiSystem.Src.Common;
using TaxiSystem.Users;

namespace TaxiSystem.Auth
{
    public class Auth
    {
        private static Auth _instance;

        public static Auth Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Auth();
                return _instance;
            }
        }

        public User Authorization(string username, string password, ref int errCode)
        {
            var mysql = MySQL.Instance();
            User user = null;
            using (var reader = mysql.Execute($"SELECT `Id`, `type`, `username`, `password` FROM `users` WHERE `username` = '{username}' AND `password` = '{MD5Hash.Get(username + ":" + password)}'"))
            {
                if (reader == null)
                    errCode = 0;
                else if (!reader.Read())
                    errCode = 1;

                if (errCode != -1)
                    return null;

                int id = reader.GetInt32(0);
                UserType type = (UserType)reader.GetByte(1);
                string username_ = reader.GetString(2);
                string password_ = reader.GetString(3);

                switch ((UserType)reader.GetInt32(1))
                {
                    case UserType.USER_TYPE_CLIENT:
                        user = new Client(id, username_, new AuthToken(username_, password_));
                        break;
                    case UserType.USER_TYPE_DRIVER:
                        user = new Driver(id, username_, new AuthToken(username_, password_));
                        break;
                    case UserType.USER_TYPE_MANAGER:
                        user = new Manager(id, username_, new AuthToken(username_, password_));
                        break;
                    default:
                        throw new NotSupportedException(string.Format($"Auth::Authorization: Unknown user type {0}", type));
                }
            }

            return user;
        }
    }
}
