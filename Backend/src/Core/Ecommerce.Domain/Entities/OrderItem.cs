using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class OrderItem: BaseDomainModel
{
    public Product? Product { get; set; }
    public int ProductId { get; set; }
    [Column(TypeName = "DECIMAL(10,2)")]
    public decimal Price { get; set; }
    public int Amount { get; set; }
    public Order? Order { get; set; }
    public int OrderId { get; set; }
    public int ProductItemId { get; set; }
    public string? ImageURL { get; set; }
}