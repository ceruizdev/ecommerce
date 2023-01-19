
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Product : BaseDomainModel
{
    [Column(TypeName = "NVARCHAR(100)")]
    public string? Name { get; set; }
    [Column(TypeName = "DECIMAL(10,2)")]
    public decimal Price { get; set; }
    [Column(TypeName = "NVARCHAR(MAX)")]
    public string? Description { get; set; }
    public int Rating { get; set; }
    public string? Seller { get; set; }
    public int Stock { get; set; }
    public ProductStatus Status { get; set; } = ProductStatus.Active;
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public virtual ICollection<Review>? Reviews { get; set; }
    public virtual ICollection<ProductImage>? ProductImages { get; set; }

}