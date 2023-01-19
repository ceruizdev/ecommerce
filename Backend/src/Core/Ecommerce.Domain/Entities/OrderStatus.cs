using System.Runtime.Serialization;

namespace Ecommerce.Domain;

public enum OrderStatus
{
    [EnumMember(Value = "Pending")]
    Pending,
    [EnumMember(Value = "Payment successful")]
    Completed,
    [EnumMember(Value = "Product sent")]
    Sent,
    [EnumMember(Value = "Payment rejected")]
    Error,
}