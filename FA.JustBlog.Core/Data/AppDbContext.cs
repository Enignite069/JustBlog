using FA.JustBlog.Core.Configurations;
using FA.JustBlog.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.Data
{
	public class AppDbContext : IdentityDbContext
	{
		public AppDbContext()
		{
			
		}

		public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
		{
		}

		public DbSet<Categories> Categories { get; set; }
		public DbSet<Comments> Comments { get; set; }
		public DbSet<Posts> Posts { get; set; }
		public DbSet<Tags> Tags { get; set; }
		public DbSet<PostTag> PostTags { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=DESKTOP-V3DI2JI;Database=JustBlog_Tag_Comment;Trusted_Connection=True;MultipleActiveResultSets=true;");
			optionsBuilder.EnableSensitiveDataLogging();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostTagConfiguration).Assembly);

			modelBuilder.SeedData();
		}
	}
}