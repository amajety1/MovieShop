using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class CastRepository : BaseRepository<Cast>, ICastRepository
{
    public CastRepository(MovieShopDbContext dbContext) : base(dbContext)
    {
    }
    
    public Cast GetCastWithMovies(int id)
    {
        return _movieShopDbContext.Casts
            .Include(c => c.MovieCasts)
            .ThenInclude(mc => mc.Movie)
            .FirstOrDefault(c => c.Id == id);
    }
}
