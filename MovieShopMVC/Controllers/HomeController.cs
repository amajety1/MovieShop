using System.Diagnostics;
using ApplicationCore.Contracts.Services;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using MovieShopMVC.Models;

namespace MovieShopMVC.Controllers;

public class HomeController : Controller
{
  private IMovieService movieService;
    public HomeController(IMovieService _movieService)
    {
      movieService =  _movieService;
    }
    

    public IActionResult Index()
    {
      var movies = movieService.GetTop30GrossingMovies();
        return View(movies);
    }

    public IActionResult Privacy()
    {
      ViewData["Message"] = "HIIII";
      ViewData["Age"] = 22;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
