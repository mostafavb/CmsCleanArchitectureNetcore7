using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cms.Data.Entities;
public class User : BaseClass
{
    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    [StringLength(50)]
    [EmailAddress]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Required]
    [StringLength(50)]
    [PasswordPropertyText]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [StringLength(14)]
    public string? Phone { get; set; }
}
