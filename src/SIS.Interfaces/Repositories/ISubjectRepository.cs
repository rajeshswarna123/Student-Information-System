using SIS.Entities;
using System.Collections.Generic;

namespace SIS.Interfaces.Repositories
{
    public interface ISubjectRepository
    {
        List<Subject> GetSubjectsByIds(List<long> subjectIds);
    }
}
