using System.Collections.Generic;

public class RepoService<T>
    : IRepoService<T>
{
    private readonly List<T> _items =
        new();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public List<T> GetAll()
    {
        return _items;
    }
}