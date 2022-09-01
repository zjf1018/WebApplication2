using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models.ViewModels
{
    public class LoginModel
    {
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [UIHint("password")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; } = "/";
    }
}