using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repositories;

public interface ICastRepository : IRepository<Cast>
{
    Cast GetCastWithMovies(int id);
}
