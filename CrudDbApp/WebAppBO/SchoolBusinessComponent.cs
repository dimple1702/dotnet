using System;
using System.Collections.Generic;
using WebAppBO.Interface;
using WebAppDO.Interface;
using WebAppEntities.CustomEntities;
using WebAppEntities.Entities;

namespace WebAppBO
{
    public class SchoolBusinessComponent : ISchoolBusinessComponent
    {
        private readonly ISchoolDataAccess _schoolDataAccess;
        public SchoolBusinessComponent(ISchoolDataAccess schoolDataAccess)
        {
            _schoolDataAccess = schoolDataAccess;
        }

        public int DeleteStudent(long StudentId)
        {
            return _schoolDataAccess.DeleteStudent(StudentId);
        }

        public Student GetStudentById(long StudentId)
        {
            return _schoolDataAccess.GetStudentById(StudentId);
        }

        public List<Student> GetStudents()
        {
            return _schoolDataAccess.GetStudents();
        }

        public Teacher GetTeacherById(long id)
        {
            return _schoolDataAccess.GetTeacherById(id);
        }

        public List<Teacher> GetTeachers()
        {
            return _schoolDataAccess.GetTeachers();
        }

        public List<Location> GetLocations()
        {
            return _schoolDataAccess.GetLocations();
        }

        public long InsertUpdateStudent(Student student)
        {
            return _schoolDataAccess.InsertUpdateStudent(student);
        }

        public List<Student> Pagination(int PageNumber, int PageSize, List<Student> students)
        {
            return _schoolDataAccess.Pagination(PageNumber, PageSize, students);
        }

        public List<CollectiveData> SearchData(string search)
        {
            return _schoolDataAccess.SearchData(search);
        }

        public List<Student> sort(string Order)
        {
            return _schoolDataAccess.sort(Order);
        }

    }
}
