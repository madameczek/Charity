namespace Charity.Domain;

public class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    
    public string? Description { get; set; }
    
    public IEnumerable<Donation>? Donations { get; set; }
}