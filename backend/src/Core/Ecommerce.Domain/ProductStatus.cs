using System.Runtime.Serialization;

namespace Ecommerce.Domain;

public enum ProductStatus{
    [EnumMember(Value = "Active Product")]
    Active,
    [EnumMember(Value = "Inactive Product")]
    Inactive
}