namespace Infrastructure.Repositories;
using ApplicationCore.Contracts.Repositories;

public class BaseRepository<T> : IRepository<T> where T : class
{
    public T Insert(T entity)
    {
        throw new NotImplementedException();
    }

    public T DeleteById(int id)
    {
        throw new NotImplementedException();
    }

    public T Update(T entity)
    {
        throw new NotImplementedException();
    }

    public T GetById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        throw new NotImplementedException();
    }
}
