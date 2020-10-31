using AutoMapper;
using SIS.Entities;
using SIS.Interfaces.Repositories;
using SIS.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace SIS.Services
{
    public class StudentService: IStudentService
    {
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;
        private readonly IClassRepository _classRepository;
        private readonly IClassCurriculumRepository _classCurriculumRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly IMarksRepository _marksRepository;

        public StudentService(IStudentRepository studentRepository, IMapper mapper, IClassRepository classRepository, IClassCurriculumRepository classCurriculumRepository, ISubjectRepository subjectRepository, IMarksRepository marksRepository)
        {
            this._studentRepository = studentRepository;
            this._mapper = mapper;
            this._classRepository = classRepository;
            this._classCurriculumRepository = classCurriculumRepository;
            this._subjectRepository = subjectRepository;
            this._marksRepository = marksRepository;
        }

        public List<Models.Student> GetStudents()
        {
            var students = this._studentRepository.GetStudents();
            var mappedStudents = this._mapper.Map<List<Student>, List<Models.Student>>(students);
            var classes = this._classRepository.GetClasses();
            students.ForEach(student =>
            {
                mappedStudents.FirstOrDefault(_ => _.Id==student.Id).Class = classes.First(_ => _.Id == student.ClassId).Name;
            });
            return mappedStudents;
        }

        public Models.Student GetStudentById(long studentId)
        {
            var student = this._studentRepository.GetStudentByID(studentId);
            var mappedStudent = this._mapper.Map<Student,Models.Student>(student);
            mappedStudent.Class = this._classRepository.GetClassByID(student.ClassId).Name;
            return mappedStudent;
        }

        public List<Models.Marks> GetMarksByStudentId(long studentId)
        {
            var student = this._studentRepository.GetStudentByID(studentId);
            //var studentClass = this._classRepository.GetClassByID(student.ClassId);
            var subjectIds = this._classCurriculumRepository.GetClassCurricula(student.ClassId).Select(_ => _.SubjectId).ToList();
            var subjects = this._subjectRepository.GetSubjectsByIds(subjectIds);
            var marks = this._marksRepository.GetMarksByStudentId(studentId);
            var mappedMarks = this._mapper.Map<List<Models.Marks>>(marks);
            marks.ForEach(subjectMarks =>
            {
                mappedMarks.FirstOrDefault(_ => _.Id == subjectMarks.Id).Subject = subjects.First(_ => _.Id == subjectMarks.SubjectId).Name;
            });

            return mappedMarks;
        }
    }
}
