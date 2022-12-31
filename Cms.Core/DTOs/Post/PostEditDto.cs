using System.ComponentModel.DataAnnotations;

namespace Cms.Core.DTOs.Post;
public class PostEditDto
{
    [Required]
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Content { get; set; }
    public int CategoryId { get; set; }
}
