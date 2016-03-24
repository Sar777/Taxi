using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaxiSystem.Src.Common;
using TaxiSystem.Src.Object;

namespace TaxiSystem.Src.Users
{
    public class Manager : User
    {
        public Manager() : base()
        {
            UserTypeId = UserType.USER_TYPE_MANAGER;
        }
    }
}
