using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using first_project.Data;

namespace first_project.Controllers
{
    // This controller talks with the Db.
    public class StudentControllerDb : Controller
    {

        private MyAppContext _context;

        // Contructor 
        public StudentControllerDb(MyAppContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Read Data

            // To access models, we need to use the dbContext 
            // This is lambda function in C# --> s => s.Id > 1
            // And Where, ToListSync, These methods are part of "LINQ"
            var studentsData = await _context.Students.Where(s => s.Name == "Tanveer Singh").ToListAsync();

            Console.WriteLine("Hello World!");
            Console.WriteLine(studentsData);

            return Ok(studentsData);
        }
    }
}
