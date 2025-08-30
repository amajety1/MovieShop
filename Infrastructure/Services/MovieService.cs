using ApplicationCore.Contracts.Repositories;
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
  
  public MovieDetailsModel GetMovieDetails(int id)
  {
    var movie = _movieRepository.GetById(id);
    if(movie != null){
    var movieDetailsModel = new MovieDetailsModel(){
      Id = movie.Id,
      Title = movie.Title,
      Overview = movie.Overview,
      Tagline = movie.Tagline,
      Budget = movie.Budget,
      Revenue = movie.Revenue,
      PosterUrl = movie.PosterUrl
    };
    return movieDetailsModel;
    }
    return null;
  }


  public bool DeleteMovie(int id){
    var movie = _movieRepository.DeleteById(id);

    if(movie == null){
      return false;
    }
    return true;
  }

  public bool UpdateMovie(MovieDetailsModel movieDetailsModel){
    var movie = _movieRepository.GetById(movieDetailsModel.Id);
    if(movie == null){
      return false;
    }
    movie.Title = movieDetailsModel.Title;
    movie.Overview = movieDetailsModel.Overview;
    movie.Tagline = movieDetailsModel.Tagline;
    movie.Budget = movieDetailsModel.Budget;
    movie.Revenue = movieDetailsModel.Revenue;
    movie.PosterUrl = movieDetailsModel.PosterUrl;
    _movieRepository.Update(movie);
    return true;
  }
}
