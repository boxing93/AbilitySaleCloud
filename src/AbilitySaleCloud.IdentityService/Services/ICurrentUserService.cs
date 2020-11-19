using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbilitySaleCloud.IdentityService.Services
{
    public interface ICurrentUserService
    {
        string GetUserName();

        string GetId();
    }
}
