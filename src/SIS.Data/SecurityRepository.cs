using SIS.Data.Configurations;
using SIS.Entities;
using SIS.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace SIS.Data
{
    public class SecurityRepository : BaseRepository<User>, ISecurityRepository
    {
        public SecurityRepository(SISDBContext dbContext)
            : base(dbContext)
        {
        }

        public List<User> GetByCondition(Func<User, bool> condition)
        {
            return GetBy(condition);
        }
    }
}
