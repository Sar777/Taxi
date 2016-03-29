
using TaxiSystem.Src.Auth;
using TaxiSystem.Src.Common;
using TaxiSystem.Src.Object;

namespace TaxiSystem.Src.Users
{
    public class Client : User
    {
        private Order Order { get; set; }
        public Address Address { get; set; }

        public Client(int Id, string name, AuthToken token) : base(Id, name, token)
        {
            UserTypeId = UserType.USER_TYPE_CLIENT;
        }
    }
}
