using System.Collections.Generic;

namespace SIS.Interfaces.Services
{
    public interface IStudentService
    {
        List<Models.Student> GetStudents();
        Models.Student GetStudentById(long studentId);
        List<Models.Marks> GetMarksByStudentId(long studentId);
    }
}
