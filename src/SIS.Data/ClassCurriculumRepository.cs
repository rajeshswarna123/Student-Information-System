using SIS.Data.Configurations;
using SIS.Entities;
using SIS.Interfaces.Repositories;
using System.Collections.Generic;

namespace SIS.Data
{
    public class ClassCurriculumRepository : BaseRepository<ClassCurriculum>, IClassCurriculumRepository
    {
        public ClassCurriculumRepository(SISDBContext dbContext)
            : base(dbContext)
        {
        }

        public List<ClassCurriculum> GetClassCurricula(long classId)
        {
            return this.GetBy(_ => _.ClassId == classId);
        }
    }
}
