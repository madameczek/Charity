namespace Charity.Domain;

public class Donator
{
    public int Id { get; set; }
    
    public string Street { get; set; } = null!;

    public string City { get; set; } = null!;

    public string ZipCode { get; set; } = null!;

    public string ContactPerson { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;
}