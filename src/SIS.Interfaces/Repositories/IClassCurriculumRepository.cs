using SIS.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Interfaces.Repositories
{
    public interface IClassCurriculumRepository
    {
        List<ClassCurriculum> GetClassCurricula(long classId);
    }
}
