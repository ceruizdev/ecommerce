namespace Ecommerce.Domain;
using Ecommerce.Domain.Common;

public class Address: BaseDomainModel
{
    public string? Street { get; set; }
    public string? City { get; set; }   
    public string? Department { get; set; }
    public string? ZipCode { get; set; }
    public string? Username { get; set; }
    public string? Country { get; set; }

}