using System.ComponentModel.DataAnnotations;
namespace graduationProject.core.Dtos
{
    public class ChangeUserNameDto
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "new User Name is required")]
        public string newUserName { get; set; }
    }
}
