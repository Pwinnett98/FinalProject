using FinalProject.models;
using Microsoft.EntityFrameworkCore;

    namespace FinalProject.Models
{
	public class UserContext : DbContext
	{
		public UserContext (DbContextOptions<UserContext> options)
			: base(options)
		{
		}
    		public DbSet<User> Users {get; set;} = default!;
	}
}