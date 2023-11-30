using System.ComponentModel.DataAnnotations;

namespace AMS.Identity.Models;

public class SignupRequestModel
{
    [EmailAddress]
    public required string Email { get; set; }

    public required string Name { get; set; }

    public required string Password { get; set; }
}
