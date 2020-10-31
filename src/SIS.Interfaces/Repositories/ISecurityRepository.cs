using SIS.Entities;
using System;
using System.Collections.Generic;

namespace SIS.Interfaces.Repositories
{
    public interface ISecurityRepository
    {
        List<User> GetByCondition(Func<User, bool> condition);
    }
}
