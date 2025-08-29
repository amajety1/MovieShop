namespace ApplicationCore.Contracts.Repositories;

public interface IRepository<T> where T : class
{
    T Insert(T entity);
    T DeleteById(int id);
    T Update(T entity);
    T GetById(int id);
    IEnumerable<T> GetAll();
}