using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Contracts.Services;

namespace MovieShopMVC.Controllers;

public class MoviesController:Controller
{
  private readonly IMovieService _movieService;

  public MoviesController(IMovieService movieService)
  {
    _movieService = movieService;
  }
  
  public ActionResult Index()
  {
    return View();
  }
  
  public ActionResult TopRated()
  {
    var movies = _movieService.GetTop20GrossingMovies();
    return View(movies);
  }
}
