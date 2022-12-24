using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Data.Entities;

[Table("Posts_Tags")]
public class PostTag : BaseClass
{
    [Required]
    [ForeignKey("Post")]
    public int PostId { get; set; }

    [Required]
    [ForeignKey("Tag")]
    public int TagId { get; set; }

    public virtual Post Post { get; set; }
    public virtual Tag Tag { get; set; }
}
