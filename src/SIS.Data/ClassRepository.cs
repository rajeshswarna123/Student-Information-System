using Microsoft.EntityFrameworkCore;
using SIS.Data.Configurations;
using SIS.Entities;
using SIS.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SIS.Data
{
    public class ClassRepository : BaseRepository<Class>, IClassRepository
    {
        public ClassRepository(SISDBContext dbContext)
            : base(dbContext)
        {
        }

        public Class GetClassByID(long classId)
        {
            return GetById(classId);
        }

        public List<Class> GetClasses()
        {
            return this.GetAll();
        }

    }
}
