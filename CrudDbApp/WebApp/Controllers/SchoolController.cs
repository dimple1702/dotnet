using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppBO.Interface;
using WebAppEntities.CustomEntities;
using WebAppEntities.Entities;

namespace WebApp.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ISchoolBusinessComponent _schoolBusinessComponent;

        public SchoolController(ISchoolBusinessComponent schoolBusinessComponent)
        {
            _schoolBusinessComponent = schoolBusinessComponent;
        }

        public IActionResult GetCollectiveData(string search, int PageNumber = 1)
        {
            ViewBag.Search = search;
            var list = _schoolBusinessComponent.SearchData("");

            if (search == null)
            {
                list = ApplyPagination(list, PageNumber);
                return View(list);
            }
            else
            {
                list = _schoolBusinessComponent.SearchData(search);
                list = ApplyPagination(list, PageNumber);
                return View(list);
            }
        }
            
        //public IActionResult StudentList(string Order, int PageNumber = 1)
        //{
        //    var list = _schoolBusinessComponent.GetStudents();
        //    list = _schoolBusinessComponent.sort(Order);

        //    return View(list);
        //}

        public IActionResult StudentList(int PageNumber = 1)
        {
            var list = _schoolBusinessComponent.GetStudents();

            ViewBag.TotalPages = Math.Ceiling(list.Count() / 5.0);
            ViewBag.PageNumber = PageNumber;

            list = _schoolBusinessComponent.Pagination(PageNumber, 5, list);
            
            return View(list);
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            List<Teacher> teachers = _schoolBusinessComponent.GetTeachers();
            List<Location> locations = _schoolBusinessComponent.GetLocations();

            List<string> locationList = new List<string>();
            List<string> teacherList = new List<string>();

            foreach (var item in locations)
            {
                locationList.Add(item.Address);
            }

            foreach (var item in teachers)
            {
                teacherList.Add(item.TeacherFname);
            }

            ViewBag.Address = locationList;
            ViewBag.TeacherName = teacherList;
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            _schoolBusinessComponent.InsertUpdateStudent(student);
            return RedirectToAction("StudentList");
        }

        public IActionResult ViewStudent(long Id)
        {
            Student student = _schoolBusinessComponent.GetStudentById(Id);
            return View(student);
        }

        [HttpGet]
        public ActionResult EditStudent(long id)
        {
            Student student = _schoolBusinessComponent.GetStudentById(id);
            List<Teacher> teachers = _schoolBusinessComponent.GetTeachers();
            List<Location> locations = _schoolBusinessComponent.GetLocations();

            List<string> locationList = new List<string>();
            List<string> teacherList = new List<string>();

            foreach (var item in locations)
            {
                locationList.Add(item.Address);
            }

            foreach (var item in teachers)
            {
                teacherList.Add(item.TeacherFname);
            }

            ViewBag.Address = locationList;
            ViewBag.TeacherName = teacherList;
            return View(student);
        }

        [HttpPost]
        public ActionResult EditStudent(Student student)
        {
            _schoolBusinessComponent.InsertUpdateStudent(student);
            return RedirectToAction("StudentList");
        }

        public ActionResult DeleteStudent(long id)
        {
            Student student = _schoolBusinessComponent.GetStudentById(id);
            return View(student);
        }

        [HttpPost]
        [ActionName("DeleteStudent")]
        public ActionResult ConfirmDeleteStudent(long id)
        {
            _schoolBusinessComponent.DeleteStudent(id);
            return RedirectToAction("StudentList");
        }

        public IActionResult ViewTeacher(long Id)
        {
            Teacher teacher = _schoolBusinessComponent.GetTeacherById(Id);
            return View(teacher);
        }

        public List<CollectiveData> ApplyPagination(List<CollectiveData> data, int PageNumber)
        {
            ViewBag.TotalPages = Math.Ceiling(data.Count() / 5.0);
            ViewBag.PageNumber = PageNumber;
            
            data = data.Skip((PageNumber - 1) * 5).Take(5).ToList();
            return data;
        }
    }
}
