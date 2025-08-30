using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repositories;

public interface IUserRepository : IRepository<User>
{
    User GetUserByEmail(string email);
    User GetUserWithPurchases(int id);
}
