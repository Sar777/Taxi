using TaxiSystem.Auth;
using TaxiSystem.Common;
using TaxiSystem.Object;
using TaxiSystem.Src.Common;

namespace TaxiSystem.Users
{
    public class Client : User
    {
        private Order Order { get; set; }
        public Address Address { get; set; }

        public Client(int id, string name, AuthToken token) : base(id, name, token)
        {
            UserTypeId = UserType.USER_TYPE_CLIENT;
        }

        public override void SaveToDb(bool trans = true)
        {
            base.SaveToDb(trans);
        }
    }
}
