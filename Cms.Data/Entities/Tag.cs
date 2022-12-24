using System.ComponentModel.DataAnnotations;

namespace Cms.Data.Entities;
public class Tag : BaseClass
{
    [Required]
    [MaxLength(50)]
    public string? Title { get; set; }
    public virtual ICollection<PostTag> PostTags { get; set; }
}
