using System.ComponentModel.DataAnnotations;

namespace CookantsEntity.ViewModel
{
   public  class LoginView
    {
        [Required]
        [EmailAddress(ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Display(Name = "Remember Me?")]
        public bool RememberMe { get; set; }
    }
}
