using SIS.Data.Configurations;
using SIS.Entities;
using SIS.Interfaces.Repositories;
using System.Collections.Generic;

namespace SIS.Data
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(SISDBContext dbContext)
            : base(dbContext)
        {
        }

        public List<Student> GetStudents()
        {
            return GetAll();
        }

        public Student GetStudentByID(long studentId)
        {
            return GetById(studentId);
        }
    }
}
