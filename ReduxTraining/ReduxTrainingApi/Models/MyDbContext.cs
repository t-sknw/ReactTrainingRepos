using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReduxTrainingApi.Models
{
	public class MyDbContext : DbContext
	{
		public MyDbContext(DbContextOptions<MyDbContext> options)
			: base(options)
		{

		}

		public DbSet<Auther> Authers { get; set; }

		public DbSet<Course> Courses { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Auther>().ToTable("Auther");
			modelBuilder.Entity<Course>().ToTable("Course");
		}

	}
}
