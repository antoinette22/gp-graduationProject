using System.ComponentModel.DataAnnotations;
namespace graduationProject.core.Dtos
{
    public class ChangeUserEmailDto
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }

        //[Required(ErrorMessage = "Email is required")]
        //public string Email { get; set; }

        [Required(ErrorMessage = "newEmail is required")]
        public string newEmail { get; set; }

    }
}
