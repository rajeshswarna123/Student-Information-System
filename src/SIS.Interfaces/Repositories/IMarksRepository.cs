using SIS.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Interfaces.Repositories
{
    public interface IMarksRepository
    {
        List<Marks> GetMarksByStudentId(long studentId);
    }
}
