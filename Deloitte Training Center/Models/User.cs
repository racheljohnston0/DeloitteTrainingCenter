using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Deloitte_Training_Center.Models
{
    public class User
    {
        public int id { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public required string email{ get; set; }

        [Required]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "The password must be at least 8 characters long and no more than 16 characters.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "The password must contain at least one lowercase letter, one uppercase letter, and one number.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public required string password{ get; set; }
    }
}
