using System.ComponentModel.DataAnnotations;

namespace TESTIO.Models
{
    public class RegistrationModel
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Surname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
