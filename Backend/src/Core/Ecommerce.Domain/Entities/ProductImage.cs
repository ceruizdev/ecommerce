using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;
public class ProductImage: BaseDomainModel
{
    [Column(TypeName = "NVARCHAR(1000)")]
    public string? URL {get; set;}
    public int ProductId { get; set; }
    public string? PublicCode { get; set; }
    public Product? Product { get; set; }
}