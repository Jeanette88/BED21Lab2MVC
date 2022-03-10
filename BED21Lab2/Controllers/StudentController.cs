using BED21Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BED21Lab2.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            var studentList = new List<Student>{
                            new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                            new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                            new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                            new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                            new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                            new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                            new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
                        };
            // Get the students from the database in the real application

            return View(studentList);
        }


        //GET: Student
        //public string Index()
        //{
        //    return "This is Index action method of StudentController";
        //}

        //[NonAction]
        //public Student GetStudent(int id)
        //{
        //    return studentList.Where(s => s.StudentId == id).FirstOrDefault();
        //}

        //[HttpPost]
        //public ActionResult Edit(Student std)
        //{
        //    // update student to the database

        //    return RedirectToAction("Index");
        //}

        //[HttpDelete]
        //public ActionResult Delete(int id)
        //{
        //    // delete student from the database whose id matches with specified id

        //    return RedirectToAction("Index");
        //}
    }
}
