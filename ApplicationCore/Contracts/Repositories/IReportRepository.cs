namespace ApplicationCore.Contracts.Repositories;

public interface IReportRepository
{
    int GetMoviesCount();
    int GetUsersCount();
    decimal GetTotalRevenue();
    int GetPurchasesCount();
    List<(int movieId, decimal totalRevenue)> GetTop10RevenueMovies();
    List<(DateTime purchaseDateTime, string movieTitle, string userName, decimal totalPrice)> GetRecentPurchases();
}
