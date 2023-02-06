using Charity.Domain;

namespace Charity.BusinessLogic.Interfaces;

public interface IRepository
{
    Task<IEnumerable<Donation>> GetDonations();

}