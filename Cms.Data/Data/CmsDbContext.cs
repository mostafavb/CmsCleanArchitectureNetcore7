using Cms.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Reflection;

namespace Cms.Data.Data;
public class CmsDbContext : DbContext
{    
	public CmsDbContext(DbContextOptions options)
		:base(options)
	{
       
    }

	public virtual DbSet<Post> Posts { get; set; }
	public virtual DbSet<Category> Categories{ get; set; }
	public virtual DbSet<Comment> Comments{ get; set; }
	public virtual DbSet<Tag> Tags{ get; set; }
	public virtual DbSet<User> Users{ get; set; }
	public virtual DbSet<PostTag> PostTags { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        foreach (var property in builder.Model.GetEntityTypes()
               .SelectMany(t => t.GetProperties())
               .Where(p => p.Name is "CreatedDate"))
        {
            property.SetColumnType("datetime");
            property.SetDefaultValueSql("getdate()");

        }

        base.OnModelCreating(builder);
    }

}
public class CmsContextFactory : IDesignTimeDbContextFactory<CmsDbContext>
{
    public CmsDbContext CreateDbContext(string[] args)
    {
		var optionsBuilder = new DbContextOptionsBuilder<CmsDbContext>();        
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CmsDB;Trusted_Connection=True;MultipleActiveResultSets=True");
		return new CmsDbContext(optionsBuilder.Options);
        
    }
}
