using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Data.Entities;
public class Comment:BaseClass
{
    [Required]
    [MinLength(5)]
    [MaxLength(500)]
    public string Content { get; set; }

    [Required]
    [ForeignKey("Post")]
    public int PostId { get; set; }
}
