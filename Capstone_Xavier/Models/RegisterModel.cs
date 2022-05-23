

namespace Capstone_Xavier.Models
{
    using System.ComponentModel.DataAnnotations;
    public class RegisterModel:BaseModel
    {
        [Required]
        [MaxLength(15, ErrorMessage = "Username cannot be above 15 characters")]
        [RegularExpression("([a-zA-Z0-9]{3,15})", ErrorMessage = "Only alphanumeric characters allowed")]
        public string username { get; set; }
        public int userValid = 0;


        [Required]
        public string password { get; set; }
        public int passValid = 0;

        [Required]
        [EmailAddress]
        public string email { get; set; }
        public int emailValid = 0;

    }
}