using ExampleApi.Interfaces.InterfaceIEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApi.InterfaceReporsitory
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> AddItem(T entity);
        Task<T> UpdateItem(T entity);
        Task<T> DeleteItem(int id);
    }
}
