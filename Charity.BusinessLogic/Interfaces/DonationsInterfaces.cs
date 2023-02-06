using Charity.Domain;

namespace Charity.BusinessLogic.Interfaces;

public interface ICreateDonationUseCase
{
    Task<int> ExecuteAsync(Donation donation);
}

public interface IViewDonationsUseCase
{
    Task<IEnumerable<Donation>> ExecuteAsync();
}