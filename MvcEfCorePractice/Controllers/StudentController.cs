using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcEfCorePractice.Data;
using MvcEfCorePractice.Models;

namespace MvcEfCorePractice.Controllers
{
    public class StudentController : Controller
    {
        private readonly Applicationdbcontext _appdbcontext;

        public StudentController(Applicationdbcontext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }

        [HttpGet]
        public IActionResult Index(string searchString)
        {
            var students = from s in _appdbcontext.students
                           select s;

            if (!string.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.Name.Contains(searchString) ||
                                               s.Age.ToString().Contains(searchString));
            }

            return View(students.ToList());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _appdbcontext.Add(student);
                _appdbcontext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student= _appdbcontext.students.FirstOrDefault(s => s.Id == id);
            if(student==null)
            {
                return NotFound();

            }
            return View(student);

        }
        [HttpPost]
       
        public IActionResult Edit(int id,Student student)
        {

            if(id!=student.Id)
            {
                return NotFound();    
            }
            if(ModelState.IsValid)
            {
                _appdbcontext.Update(student);
                _appdbcontext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
        public IActionResult Delete(int id)
        {
            var student = _appdbcontext.students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost, ActionName("Delete")]
      
        public IActionResult DeleteConfirmed(int id)
        {
            var student = _appdbcontext.students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            _appdbcontext.students.Remove(student);
            _appdbcontext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
