using Charity.BusinessLogic.Interfaces;
using Charity.Domain;

namespace Charity.RepositoryInMemory;

public class InMemoryDonationRepository : IRepository
{
    private readonly List<Donation> _donations;

    public InMemoryDonationRepository()
    {
        _donations = new List<Donation>
        {
            new() { Id = 1, Quantity = 1, PickupOn = DateTime.Now.AddDays(-5), IsPicked = false, Comment = "Office closed"},
            new() { Id = 2, Quantity = 3, PickupOn = DateTime.Now.AddDays(5), IsPicked = false, Comment = "Be by noon"},
            new() { Id = 3, Quantity = 5, PickupOn = DateTime.Now.AddDays(-2), IsPicked = true, Comment = "Nice stuff"},
            new() { Id = 4, Quantity = 2, PickupOn = DateTime.Now.AddDays(2), IsPicked = false, Comment = "Ask for Jerry"},
            new() { Id = 5, Quantity = 6, PickupOn = DateTime.Now, IsPicked = false }
        };
    }
    
    public async Task<IEnumerable<Donation>> GetDonations()
    {
        return _donations;
    }
}