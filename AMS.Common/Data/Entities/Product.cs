namespace AMS.Common.Data.Entities;

public class Product : BaseEntity
{
    public int Quantity { get; set; }

    public decimal Price { get; set; }
}