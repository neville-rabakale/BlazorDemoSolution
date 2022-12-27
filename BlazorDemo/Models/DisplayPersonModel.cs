using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [StringLength(15, ErrorMessage ="First Name is too long")]
        [MinLength(5, ErrorMessage ="First Name is too short")]
        public string FirstName { get; set; } = null!;
        [Required]
        [StringLength(15, ErrorMessage = "Last Name is too long")]
        [MinLength(5, ErrorMessage = "Last Name is too short")]
        public string LastName { get; set; } = null!;
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
    }
}
