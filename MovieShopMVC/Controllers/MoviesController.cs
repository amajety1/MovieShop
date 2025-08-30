using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;

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

[HttpGet]
  public IActionResult Edit(int id)
  {
    var movie = _movieService.GetMovieDetails(id);
    if(movie == null)
    {
      return NotFound();
    }
    return View(movie);
  }
  
  public ActionResult TopRated()
  {
    var movies = _movieService.GetTop20GrossingMovies();
    return View(movies);
  }

  [HttpGet]
  public IActionResult MovieDetails(int id)
  {
    var movie = _movieService.GetMovieDetails(id);
    return View(movie);
 
  }

[HttpPost]
public IActionResult DeleteMovie(int id)
{
  var movie = _movieService.GetMovieDetails(id);
  if(movie == null){
    return NotFound();
  }
  _movieService.DeleteMovie(id);
  return RedirectToAction("Index", "Home");
}

[HttpPost]
public IActionResult UpdateMovie(MovieDetailsModel movieDetailsModel)
{
  if (!ModelState.IsValid)
  {
    return View("Edit", movieDetailsModel);
  }
  
  var movie = _movieService.GetMovieDetails(movieDetailsModel.Id);
  if(movie == null){
    return NotFound();
  }
  
  _movieService.UpdateMovie(movieDetailsModel);
  return RedirectToAction("MovieDetails", new { id = movieDetailsModel.Id });
}


}
