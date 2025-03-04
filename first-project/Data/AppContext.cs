
using Microsoft.EntityFrameworkCore;
using first_project.Models;

namespace first_project.Data
{
	// DbContext class contains inbuilt methods to query the database (part of EF Core)
	public class MyAppContext : DbContext
	{
		// constuctor	
		public MyAppContext(DbContextOptions<MyAppContext> options) : base(options)
		{

		}

        // Student -> model, given to DbSet 
		// Students -> is the connection to Student via EF Core
        public DbSet<Student> Students { get; set; } 
	}
}

