using ApplicationCore.Contracts.Services;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Models;
using ApplicationCore.Entities;

namespace Infrastructure.Services;

public class CastService : ICastService
{
    private readonly ICastRepository _castRepository;
    
    public CastService(ICastRepository castRepository)
    {
        _castRepository = castRepository;
    }
    
    public CastModel GetCastDetails(int id)
    {
        var cast = _castRepository.GetCastWithMovies(id);
        if (cast == null)
        {
            return null;
        }
        
        var castModel = new CastModel
        {
            Id = cast.Id,
            Name = cast.Name,
            ProfilePath = cast.ProfilePath
        };
        
        return castModel;
    }
    
    public List<MovieCardModel> GetMoviesByCastId(int id)
    {
        var cast = _castRepository.GetCastWithMovies(id);
        if (cast == null || cast.MovieCasts == null)
        {
            return new List<MovieCardModel>();
        }
        
        var movies = new List<MovieCardModel>();
        foreach (var movieCast in cast.MovieCasts)
        {
            movies.Add(new MovieCardModel
            {
                Id = movieCast.Movie.Id,
                Title = movieCast.Movie.Title,
                PosterUrl = movieCast.Movie.PosterUrl
            });
        }
        
        return movies;
    }
    
    public int CreateCast(CastModel castModel)
    {
        var cast = new Cast
        {
            Name = castModel.Name,
            ProfilePath = castModel.ProfilePath,
            Gender = "Unknown" // Default value, should be provided in the model
        };
        
        var createdCast = _castRepository.Insert(cast);
        return createdCast.Id;
    }
    
    public bool UpdateCast(CastModel castModel)
    {
        var cast = _castRepository.GetById(castModel.Id);
        if (cast == null)
        {
            return false;
        }
        
        cast.Name = castModel.Name;
        cast.ProfilePath = castModel.ProfilePath;
        
        _castRepository.Update(cast);
        return true;
    }
    
    public bool DeleteCast(int id)
    {
        var cast = _castRepository.DeleteById(id);
        return cast != null;
    }
}
