using SIS.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Interfaces.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();

        Student GetStudentByID(long studentId);
    }
}
