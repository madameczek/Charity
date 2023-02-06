using Charity.BusinessLogic.Interfaces;
using Charity.Domain;

namespace Charity.BusinessLogic.Donations;

public class CreateDonationUseCase : ICreateDonationUseCase
{
    public async Task<int> ExecuteAsync(Donation donation)
    {
        return await Task.FromResult(1);
    }
}