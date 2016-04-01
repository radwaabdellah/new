using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FristLook.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> Students = new List<Student>()
        {
            new Student {Id=1, Name="Ahmed" },
            new Student {Id=2, Name="Heba" }
        };

        [HttpGet]
        public JsonResult Get(int id)
        {
            return
                Json(Students.FirstOrDefault(st => st.Id == id),JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return
                Json(Students, JsonRequestBehavior.AllowGet);
        }

        [HttpPut]
        public void Add(Student student)
        {

            Students.Add(student);
        }

        [HttpPost]
        public void Modify(Student student)
        {
            Students.RemoveAll(st => st.Id == student.Id);
            Students.Add(student);
        }

        [HttpDelete]
        public void Remvoe(int id)
        {
            Students.RemoveAll(st => st.Id == id);
        }
    }

    public  class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}