using System.ComponentModel.DataAnnotations;

namespace AMS.Common.Data.Entities;

public abstract class BaseUser : BaseEntity
{
    [MaxLength(100)]
    public required string Name { get; set; }

    [MaxLength(256)]
    public required string Email { get; set; }

    [MaxLength(256)]
    public required string PasswordHash { get; set; }
}