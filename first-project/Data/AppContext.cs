
using Microsoft.EntityFrameworkCore;
using first_project.Models;

namespace first_project.Data
{
	// DbContext class contains inbuilt methods to query the database
	public class MyAppContext : DbContext
	{
		// constuctor
		public MyAppContext(DbContextOptions<AppContext> options) : base(options)
		{

		}

		public DbSet<Student> Students { get; set; } 
	}
}

