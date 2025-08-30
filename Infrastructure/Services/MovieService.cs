using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;

namespace Infrastructure.Services;

public class MovieService:IMovieService
{

  private readonly IMovieRepository _movieRepository;
  
  public MovieService(IMovieRepository movieRepository){
    _movieRepository = movieRepository;
  }

  public List<MovieCardModel> GetTop20GrossingMovies()
  {
    var movies = _movieRepository.GetTop20GrossingMovies();
    var movieCardModels = new List<MovieCardModel>();
    foreach(var movie in movies){
      movieCardModels.Add(new MovieCardModel{
        Id = movie.Id,
        Title = movie.Title,
        PosterUrl = movie.PosterUrl
      });
    }
    return movieCardModels;
  }
  
}
