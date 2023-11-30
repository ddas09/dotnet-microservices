using System.ComponentModel.DataAnnotations.Schema;

namespace AMS.Common.Data.Entities;

public class Order : BaseEntity
{
    public int BuyerId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TotalPrice { get; set; }

    [ForeignKey(nameof(BuyerId))]
    public required User Buyer { get; set; }
}