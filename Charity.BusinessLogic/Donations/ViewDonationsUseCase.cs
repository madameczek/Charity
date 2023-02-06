using Charity.BusinessLogic.Interfaces;
using Charity.Domain;

namespace Charity.BusinessLogic.Donations;

public class ViewDonationsUseCase : IViewDonationsUseCase
{
    private readonly IRepository _repository;

    public ViewDonationsUseCase(IRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Donation>> ExecuteAsync()
    {
        return await _repository.GetDonations();
    }
}