using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Data.Entities;
public class Post : BaseClass
{
    [Required]
    [MaxLength(50)]
    public string Title { get; set; }

    [MinLength(5)]
    [MaxLength(500)]
    public string Content { get; set; }

    [ForeignKey("Category")]
    public int CategoryId { get; set; }

    public virtual Category Category{ get; set; }
    public virtual ICollection<Comment>? Comments { get; set; }
    public virtual ICollection<PostTag>? PostTags{ get; set; }
}
