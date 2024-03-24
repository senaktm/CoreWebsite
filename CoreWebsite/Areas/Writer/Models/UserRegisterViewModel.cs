using System.ComponentModel.DataAnnotations;

namespace CoreWebsite.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage ="Please enter username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }


        [Compare("Password",ErrorMessage ="Password and confirm password didn't match")]
        [Required(ErrorMessage = "Please enter confirm password")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Please enter email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please enter imageUrl")]
        public string ImageUrl { get; set; }
    }
}
