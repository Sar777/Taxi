
using TaxiSystem.Src.Common;
using TaxiSystem.Src.Object;

namespace TaxiSystem.Src.Users
{
    public class Client : User
    {
        private Order Order { get; set; }
        public Address Address { get; set; }

        public Client() : base()
        {
            UserTypeId = UserType.USER_TYPE_CLIENT;
        }

        public Client(int Id, string name) : base(Id, name)
        {
            UserTypeId = UserType.USER_TYPE_CLIENT;
        }
    }
}
