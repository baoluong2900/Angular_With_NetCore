using DappingAppChat.Entities;
using Microsoft.EntityFrameworkCore;

namespace DappingAppChat.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<Table_Users>()
			//									.Property(b => b.UserName)
			//									.IsOptional();
			//modelBuilder.Entity<Table_Users>()
			//									.Property(b => b.Active)
			//									.HasDefaultValue(true);
			//modelBuilder.Entity<Table_Users>()
			//									.Property(b => b.Active)
			//									.HasDefaultValue(true);

			//modelBuilder.Entity<Table_Users>()
			//									.Property(b => b.Active)
			//									.HasDefaultValue(true);
			//modelBuilder.Entity<Table_Users>()
			//									.Property(b => b.CreateDate)
			//									.HasDefaultValueSql("getdate()");

			//base.OnModelCreating(modelBuilder);
		}

		public DbSet<Users> Users { get; set; }
	}
}
