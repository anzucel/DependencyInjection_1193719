using System;
using System.Collections.Generic;

namespace Dependency_Injection_1193719
{
    public interface IUserService
    {
        List<user> GetUsersInfo(string[] username);
    }
}
