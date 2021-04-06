using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebAppDO.Interface;
using WebAppEntities.CustomEntities;
using WebAppEntities.Entities;

namespace WebAppDO
{
    public class SchoolDataAccess : ISchoolDataAccess
    {
        private readonly SchoolDbContext _schoolDbContext;

        public SchoolDataAccess(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        public List<CollectiveData> SearchData(String search)
        {
            List<CollectiveData> list;
            try
            {
                list = _schoolDbContext.CollectiveData.
                    FromSqlRaw("[dbo].[spSearch] @Search",
                    new SqlParameter("@Search", search ?? (object)DBNull.Value)
                ).ToList();
            }
            catch (Exception e)
            {
                list = null;
                Console.WriteLine(e);
            }
            return list;
        }

        //Pagination using Stored Procedure
        public List<Student> Pagination(int PageNumber, int PageSize, List<Student> students)
        {
            try
            {
                students = _schoolDbContext.Student.FromSqlRaw("exec [dbo].[spPagination2] " + PageNumber + ",5").ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return students;
        }

        // sorting the data 
        public List<Student> sort(string Order)
        {
            var list = _schoolDbContext.Student.ToList();
            switch (Order)
            {
                case "ASC":
                    list = list.OrderBy(x => x.StudentFname).ToList();
                    break;
                case "DESC":
                    list = list.OrderByDescending(x => x.StudentFname).ToList();
                    break;
                default:
                    list = list.OrderBy(x => x.StudentFname).ToList();
                    break;
            }
            return list;
        }

     

        // Insertion and Update operation using Stored Procedures.
        public long InsertUpdateStudent(Student student)
        {
            long result = 0;
            long studentId = student.StudentId;
            SqlParameter resultParameter = new SqlParameter();
            try
            {
                resultParameter.ParameterName = "@Result";
                resultParameter.Direction = ParameterDirection.Output;
                resultParameter.SqlDbType = SqlDbType.BigInt;

                _schoolDbContext.Database.ExecuteSqlRaw("[dbo].[spInsertUpdateStudent] @StudentId, @StudentFname, @StudentLname, @StudentEmail, @StudentPhoneNo, @StudentDob, @TeacherId, @LocId, @Result OUT",
                    new SqlParameter("@StudentId", student.StudentId),
                    new SqlParameter("@StudentFname", student.StudentFname),
                    new SqlParameter("@StudentLname", student.StudentLname),
                    new SqlParameter("@StudentEmail", student.StudentEmail),
                    new SqlParameter("@StudentPhoneNo", student.StudentPhoneNo),
                    new SqlParameter("@StudentDob", student.StudentDob),
                    new SqlParameter("@TeacherId", student.TeacherId),
                    new SqlParameter("@LocId", student.LocId),
                    resultParameter
                );

                if (Convert.ToInt32(resultParameter.Value) > 0)
                    result = Convert.ToInt32(resultParameter.Value);
            }
            catch (Exception e)
            {
                result = 0;
            }
            return result;
        }

        public Student GetStudentById(long Id)
        {
            return _schoolDbContext.Student.FirstOrDefault(e => e.StudentId == Id);
        }

        public List<Student> GetStudents()
        {
            return _schoolDbContext.Student.ToList();
        }

        public List<Teacher> GetTeachers()
        {
            return _schoolDbContext.Teacher.ToList();
        }

        public List<Location> GetLocations()
        {
            return _schoolDbContext.Location.ToList();
        }

        public Teacher GetTeacherById(long id)
        {
            return _schoolDbContext.Teacher.FirstOrDefault(e => e.TeacherId == id);
        }

        public int DeleteStudent(long StudentId)
        {
            var Obj = _schoolDbContext.Student.FirstOrDefault(x => x.StudentId == StudentId);
            _schoolDbContext.Student.Remove(Obj);
            return _schoolDbContext.SaveChanges();
        }

    }
}
