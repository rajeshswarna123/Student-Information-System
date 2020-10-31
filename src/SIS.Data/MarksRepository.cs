using SIS.Data.Configurations;
using SIS.Entities;
using SIS.Interfaces.Repositories;
using System.Collections.Generic;

namespace SIS.Data
{
    public class MarksRepository : BaseRepository<Marks>, IMarksRepository
    {
        public MarksRepository(SISDBContext dbContext)
            : base(dbContext)
        {
        }

        public List<Marks> GetMarksByStudentId(long studentId)
        {
            return this.GetBy(_ => _.StudentId == studentId);
        }
    }
}
