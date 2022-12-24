using System.ComponentModel.DataAnnotations;

namespace Cms.Data.Entities;
public class Category : BaseClass
{
    [Required]
    [MaxLength(50)]
    public string Title { get; set; }

    public virtual ICollection<Post> Posts { get; set; }
}
