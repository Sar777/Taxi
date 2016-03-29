using MySql.Data.MySqlClient;
using System;
using TaxiSystem.Src.Common;
using TaxiSystem.Src.Database.MySQL;
using TaxiSystem.Src.Object;
using TaxiSystem.Src.Users;

namespace TaxiSystem.Src.Auth
{
    public class Auth
    {
        private static Auth instance;

        public static Auth Instance
        {
            get
            {
                if (instance == null)
                    instance = new Auth();
                return instance;
            }
        }

        public User Authorization(string username, string password)
        {
            MySQL mysql = MySQL.Instance();
            string query = string.Format("SELECT `Id`, `type`, `username`, `password` FROM `users` WHERE `username` = '{0}' AND `password` = '{1}'", username, MD5Hash.GetHash(username + ":" + password));
            User user = null;
            using (MySqlDataReader reader = mysql.Execute(query))
            {
                if (!reader.Read())
                    return null;
                
                int Id = reader.GetInt32(0);
                UserType type = (UserType)reader.GetByte(1);
                string username_ = reader.GetString(2);
                string password_ = reader.GetString(3);

                switch ((UserType)reader.GetInt32(1))
                {
                    case UserType.USER_TYPE_CLIENT:
                        user = new Client(Id, username_, new AuthToken(username_, password_));
                        break;
                    case UserType.USER_TYPE_DRIVER:
                        user = new Driver(Id, username_, new AuthToken(username_, password_));
                        break;
                    case UserType.USER_TYPE_MANAGER:
                        user = new Manager(Id, username_, new AuthToken(username_, password_));
                        break;
                    default:
                        Console.WriteLine("Auth::Authorization: Unknown user type {0}", type);
                        break;
                }
            }

            return user;
        }
    }
}
