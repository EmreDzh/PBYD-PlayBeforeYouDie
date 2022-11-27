using System.ComponentModel.DataAnnotations;
using PlayBeforeYouDie.Core.Constants.Core;

namespace PlayBeforeYouDie.Core.Models.Users;

public class LoginModel
{
    [Required]
    [StringLength(UserConstants.UserNameMaxLength, MinimumLength = UserConstants.UserNameMinLength)]
    public string UserName { get; set; } = null!;

    [Required]
    [StringLength(UserConstants.PasswordMaxLength, MinimumLength = UserConstants.PasswordMinLength)]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;
}