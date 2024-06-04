using Microsoft.EntityFrameworkCore;

namespace BlogApi.DataAccessLayer
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-P65FJRU\\SQLEXPRESS;database=NetCoreMvcApi;integrated security=true;TrustServerCertificate=true;");
		}
		public DbSet<Employee> Employees { get; set; }
	}
}
