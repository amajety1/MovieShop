using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;

namespace Infrastructure.Services;

public class MovieService:IMovieService
{
  public List<MovieCardModel> GetTop30GrossingMovies()
  {
    var movies = new List<MovieCardModel>()
    {
      new MovieCardModel()
      {
        Id = 1,
        Title = "Inception",
        PosterUrl = "https://image.tmdb.org/t/p/w342//9gk7adHYeDvHkCSEqAvQNLV5Uge.jpg"
      },
      new MovieCardModel()
      {
        Id = 2,
        Title = "Interstellar",
        PosterUrl = "https://image.tmdb.org/t/p/w342//gEU2QniE6E77NI6lCU6Mx1NBvIx.jpg"

      },
      new MovieCardModel()
      {
        Id = 3,
        Title = "The Dark Knight",
        PosterUrl = "https://image.tmdb.org/t/p/w342//qJ2tW6WMUDux911r6m7haRef0WH.jpg"
      }

    };
    return movies;
  }
  
}
