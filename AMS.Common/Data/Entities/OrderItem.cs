using System.ComponentModel.DataAnnotations.Schema;

namespace AMS.Common.Data.Entities;

public class OrderItem : BaseEntity
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    [ForeignKey(nameof(OrderId))]
    public required Order Order { get; set; }

    [ForeignKey(nameof(ProductId))]
    public required Product Product { get; set; }
}