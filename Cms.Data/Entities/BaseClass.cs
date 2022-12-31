using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Data.Entities;
public class BaseClass
{

    [Required]
    [Key]
    public int Id { get; set; }

    
    public DateTime CreatedDate { get; set; } = default( DateTime);
}
//public class TodoItemConfiguration : IEntityTypeConfiguration<BaseClass>
//{
//    public void Configure(EntityTypeBuilder<BaseClass> builder)
//    {
//        builder.Property(t => t.CreatedDate)
//            .HasDefaultValueSql("getdate()");
            
//    }
//}
