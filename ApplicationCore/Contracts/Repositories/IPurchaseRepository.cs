using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repositories;

public interface IPurchaseRepository : IRepository<Purchase>
{
    List<Purchase> GetPurchasesByUserId(int userId);
    Purchase GetPurchaseDetails(int userId, int movieId);
}
