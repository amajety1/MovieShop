using ApplicationCore.Models;

namespace ApplicationCore.Contracts.Services;

public interface ICastService
{
    CastModel GetCastDetails(int id);
    List<MovieCardModel> GetMoviesByCastId(int id);
    int CreateCast(CastModel castModel);
    bool UpdateCast(CastModel castModel);
    bool DeleteCast(int id);
}
