using StudentProjectAttempt6.Data;
using Microsoft.AspNetCore.Mvc;
using StudentProjectAttempt6.Models;

namespace StudentProjectAttempt6.Controllers
{
    public class StudentController: Controller
    {
        private readonly ApplicationDbContext _db;
        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Student> objStudentList = _db.Students;
            return View(objStudentList);
        }
    }
}
