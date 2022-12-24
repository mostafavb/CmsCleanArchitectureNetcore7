using Cms.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

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
