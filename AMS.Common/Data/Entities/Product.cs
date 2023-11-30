using System.ComponentModel.DataAnnotations.Schema;

namespace AMS.Common.Data.Entities;

public class Product : BaseEntity
{
    public int Quantity { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}