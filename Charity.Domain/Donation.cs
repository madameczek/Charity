namespace Charity.Domain;

public class Donation
{
    public int Id { get; set; }

    public int Quantity { get; set; }

    public DateTime PickupOn { get; set; }

    public string? Comment { get; set; }

    public bool? IsPicked { get; set; }

    public IEnumerable<Category>? Categories { get; set; }
}