using System.ComponentModel.DataAnnotations;

namespace Cms.Data.Entities;
public class BaseClass
{
    [Required]
    [Key]
    public int Id { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime? CreatedDate { get; set; }= DateTime.Now;
}
