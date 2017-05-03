using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo.Data
{
    public interface IDataServiceBase<T> where T : ModelBase
    {

        Task<List<T>> GetItemsAsync();

        Task<List<T>> GetItemsNotDoneAsync();

        Task<T> GetItemAsync(int id);

        Task<int> SaveItemAsync(T item);
    }
}
