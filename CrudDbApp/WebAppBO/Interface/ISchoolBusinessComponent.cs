using System;
using System.Collections.Generic;
using System.Text;
using WebAppEntities.CustomEntities;
using WebAppEntities.Entities;

namespace WebAppBO.Interface
{
    public interface ISchoolBusinessComponent
    {
        List<CollectiveData> SearchData(String search);
        long InsertUpdateStudent(Student student);
        int DeleteStudent(long StudentId);
        Student GetStudentById(long StudentId);
        List<Student> GetStudents();
        List<Teacher> GetTeachers();
        List<Location> GetLocations();
        Teacher GetTeacherById(long id);
        List<Student> sort(string Order);
        List<Student> Pagination(int PageNumber, int PageSize, List<Student> students);
    }
}
