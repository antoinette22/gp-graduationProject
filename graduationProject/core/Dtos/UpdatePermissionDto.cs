using System.ComponentModel.DataAnnotations;

namespace graduationProject.core.Dtos
{
    public class UpdatePermissionDto
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }
        public string newUserName { get; set; }
        //newPassword
        public string NewPassword { get; set; }
        public string NewEmail { get; set; }
    }
}
