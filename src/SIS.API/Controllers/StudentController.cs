using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIS.Interfaces.Services;

namespace SIS.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            this._studentService = studentService;
        }

        [HttpGet]
        [Route("getallstudents")]
        public List<Models.Student> GetStudents()
        {
            return _studentService.GetStudents();
        }

        [HttpGet]
        [Route("getstudentbyid/{studentId}")]
        public Models.Student GetStudents(long studentId)
        {
            return _studentService.GetStudentById(studentId);
        }

        [HttpGet]
        [Route("getmarksbyid/{studentId}")]
        public List<Models.Marks> GetStudentMarks(long studentId)
        {
            return _studentService.GetMarksByStudentId(studentId);
        }
    }
}
