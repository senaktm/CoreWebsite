using System.ComponentModel.DataAnnotations;

namespace CoreWebsite.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Username")]
        [Required(ErrorMessage ="Please enter username")]
        public string Username  { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }
    }
}
