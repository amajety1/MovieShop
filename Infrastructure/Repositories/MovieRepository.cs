using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using System.Collections.Generic;
using System;


namespace Infrastructure.Repositories;

public class MovieRepository : BaseRepository<Movie>, IMovieRepository
{
    public IEnumerable<Movie> GetTop20GrossingMovies()
    {
        throw new NotImplementedException();
    }
    
}
