using PlayBeforeYouDie.Core.Constants.Core;
using System.ComponentModel.DataAnnotations;

namespace PlayBeforeYouDie.Core.Models.Users;

public class RegisterModel
{
    [Required]
    [StringLength(UserConstants.UserNameMaxLength, MinimumLength = UserConstants.UserNameMinLength)]
    public string UserName { get; set; } = null!;

    [Required]
    [EmailAddress]
    [StringLength(UserConstants.EmailMaxLength, MinimumLength = UserConstants.EmailMinLength)]
    public string Email { get; set; } = null!;

    [Required]
    [StringLength(UserConstants.PasswordMaxLength, MinimumLength = UserConstants.PasswordMinLength)]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Compare(nameof(Password))]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; } = null!;

    public string? ReturnUrl { get; set; }
}