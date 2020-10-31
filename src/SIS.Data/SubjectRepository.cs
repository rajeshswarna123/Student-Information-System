using SIS.Data.Configurations;
using SIS.Entities;
using SIS.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SIS.Data
{
    public class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
    {
        private readonly SISDBContext _dbContext;
        public SubjectRepository(SISDBContext dbContext)
            : base(dbContext)
        {
            this._dbContext = dbContext;
        }

        public List<Subject> GetSubjectsByIds(List<long> subjectIds)
        {
            return this._dbContext.Subjects.Where(_ => subjectIds.Contains(_.Id)).ToList();
        }
    }
}
