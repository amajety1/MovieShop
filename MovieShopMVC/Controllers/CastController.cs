using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Models;
using ApplicationCore.Contracts.Services;

namespace MovieShopMVC.Controllers;

public class CastController : Controller
{
    private readonly ICastService _castService;
    
    public CastController(ICastService castService)
    {
        _castService = castService;
    }
    
    // GET: Cast/Details/5
    public IActionResult Details(int id)
    {
        // Get cast details by id
        var castDetails = _castService.GetCastDetails(id);
        if (castDetails == null)
        {
            return NotFound();
        }
        
        return View(castDetails);
    }
    
    // GET: Cast/Movies/5
    public IActionResult Movies(int id)
    {
        // Get movies by cast id
        var movies = _castService.GetMoviesByCastId(id);
        if (movies == null)
        {
            return NotFound();
        }
        
        return View(movies);
    }
    
    // GET: Cast/Create
    public IActionResult Create()
    {
        // Display form to create a new cast
        return View();
    }
    
    // POST: Cast/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(CastModel castModel)
    {
        if (!ModelState.IsValid)
        {
            return View(castModel);
        }
        
        // Create new cast
        _castService.CreateCast(castModel);
        
        return RedirectToAction(nameof(Details), new { id = castModel.Id });
    }
    
    // GET: Cast/Edit/5
    public IActionResult Edit(int id)
    {
        // Get cast details for editing
        var castDetails = _castService.GetCastDetails(id);
        if (castDetails == null)
        {
            return NotFound();
        }
        
        return View(castDetails);
    }
    
    // POST: Cast/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, CastModel castModel)
    {
        if (id != castModel.Id)
        {
            return NotFound();
        }
        
        if (!ModelState.IsValid)
        {
            return View(castModel);
        }
        
        // Update cast
        _castService.UpdateCast(castModel);
        
        return RedirectToAction(nameof(Details), new { id = castModel.Id });
    }
    
    // GET: Cast/Delete/5
    public IActionResult Delete(int id)
    {
        // Get cast details for deletion confirmation
        var castDetails = _castService.GetCastDetails(id);
        if (castDetails == null)
        {
            return NotFound();
        }
        
        return View(castDetails);
    }
    
    // POST: Cast/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        // Delete cast
        _castService.DeleteCast(id);
        
        return RedirectToAction(nameof(Index), "Home");
    }
}
