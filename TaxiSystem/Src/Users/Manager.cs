
using TaxiSystem.Src.Auth;
using TaxiSystem.Src.Common;
using TaxiSystem.Src.Object;

namespace TaxiSystem.Src.Users
{
    public class Manager : User
    {
        public Manager(int Id, string name, AuthToken token) : base(Id, name, token)
        {
            UserTypeId = UserType.USER_TYPE_MANAGER;
        }
    }
}
