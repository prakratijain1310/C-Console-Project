using System.Collections.Generic;

public interface IRepoService<T>
{
    void Add(T item);

    List<T> GetAll();
}