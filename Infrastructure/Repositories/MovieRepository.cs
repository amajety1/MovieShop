using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using System.Collections.Generic;
using System;


namespace Infrastructure.Repositories;

public class MovieRepository : BaseRepository<Movie>, IMovieRepository
{
    public MovieRepository(MovieShopDbContext dbContext) : base(dbContext){

    }
    public IEnumerable<Movie> GetTop20GrossingMovies()
    {
        var movies = _movieShopDbContext.Movies.OrderByDescending(m => m.Revenue).Take(20);
        return movies;
    }
    
}
