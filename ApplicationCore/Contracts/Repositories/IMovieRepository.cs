namespace ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;

public interface IMovieRepository : IRepository<Movie>
{
    IEnumerable<Movie> GetTop20GrossingMovies();
}