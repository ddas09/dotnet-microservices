using System.ComponentModel.DataAnnotations;

namespace AMS.Common.Data.Entities;

public abstract class BaseEntity
{
    [Key]
    public int Id { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    [MaxLength(256)]
    public required string CreatedBy { get; set; }

    [MaxLength(256)]
    public required string UpdatedBy { get; set; }

    public bool IsActive { get; set; } = true;
}