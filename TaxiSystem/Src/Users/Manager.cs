using TaxiSystem.Auth;
using TaxiSystem.Object;
using TaxiSystem.Src.Common;

namespace TaxiSystem.Users
{
    public class Manager : User
    {
        public Manager(int id, string name, AuthToken token) : base(id, name, token)
        {
            UserTypeId = UserType.USER_TYPE_MANAGER;
        }
    }
}
