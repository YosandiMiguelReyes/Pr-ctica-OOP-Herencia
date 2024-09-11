
using System.Collections.Generic;
using System.Linq;

public class InMemoryRepository<T> : IRepository<T> where T : class
{
    protected readonly List<T> _entities = new List<T>();

    public void Add(T entity)
    {
        _entities.Add(entity);
    }

    public IEnumerable<T> GetAll()
    {
        return _entities;
    }

    public T GetById(int id)
    {
        var property = typeof(T).GetProperty("Id");
        if (property == null)
            return null;

        return _entities.FirstOrDefault(e => (int)property.GetValue(e) == id);
    }

    public void Remove(T entity)
    {
        _entities.Remove(entity);
    }
}
