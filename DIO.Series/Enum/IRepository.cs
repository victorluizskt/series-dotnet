using System.Collections.Generic;
namespace DIO.Series.Enum
{
    // Interface generica para repositorio de armazenamento de dados.
    public interface IRepository<T>
    {
         List<T> Lista();
         T ReturnForId(int id);
         void add(T entity);
         void delete(int id);
         void update(int id, T entity);
         int nextId();
    }
}