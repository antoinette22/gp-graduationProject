using System.ComponentModel.DataAnnotations;

namespace graduationProject.core.Dtos
{
    public class RegisterDto
    {
        [Required (ErrorMessage = "UserName is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [Required]
        public bool IsInvestor { get; set; }

    }
}
//using System.ComponentModel.DataAnnotations;

//namespace graduationProject.core.Dtos
//{
//    public class UpdatePermissionDto
//    {
//        [Required(ErrorMessage = "UserName is required")]
//        public string UserName { get; set; }
//        public string newUserName { get; set; }
//        //newPassword
//        public string NewPassword { get; set; }
//        public string NewEmail { get; set; }
//    }
//}