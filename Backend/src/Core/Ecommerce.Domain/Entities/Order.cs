using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;
public class Order: BaseDomainModel
{
    public Order(
        string CustomerName,
        string CustomerUsername,
        OrderAddress OrderAddress,
        decimal SubTotal,
        decimal Total,
        decimal Tax,
        decimal DeliveryPrice
    ){
        this.CustomerName = CustomerName;
        this.CustomerUsername = CustomerUsername;
        this.OrderAddress = OrderAddress;
        this.SubTotal = SubTotal;
        this.Total = Total;
        this.Tax = Tax;
        this.DeliveryPrice =  DeliveryPrice;
    }

    public string? CustomerName { get; set; }
    public string? CustomerUsername { get; set; }
    public OrderAddress? OrderAddress { get; set; }
    public IReadOnlyList<OrderItem>? OrderItems { get; set; }
    [Column(TypeName = "DECIMAL(10,2)")]
    public decimal SubTotal { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Pending;
    [Column(TypeName = "DECIMAL(10,2)")]
    public decimal Total { get; set; }
     [Column(TypeName = "DECIMAL(10,2)")]
    public decimal Tax { get; set; }
     [Column(TypeName = "DECIMAL(10,2)")]
    public decimal DeliveryPrice { get; set; }
    public string? PaymentIntentId { get; set; }
    public string? StripeApiKey { get; set; }
}