
using TaxiSystem.Src.Common;
using TaxiSystem.Src.Users;

namespace TaxiSystem.Src.Object
{
    public class User
    {
        public int ID { get; private set; }
        public string Name { get; private set; }

        public UserType UserTypeId { get; protected set; }

        public User()
        {
            this.ID = 0;
            this.Name = "Unknown";
            this.UserTypeId = UserType.USER_TYPE_UNKNOWN;
        }

        public User(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public Client ToClient() { return this as Client; }
        public Manager ToManager() { return this as Manager; }
        public Driver ToDriver() { return this as Driver; }
    }
}
