using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Todo.Data;
using Todo.Models;
using Xamarin.Forms;

namespace Todo
{
    public class DataServiceBase<T> : IDataServiceBase<T>
        where T : ModelBase, new()
    {
        readonly SQLiteAsyncConnection database;

        public DataServiceBase()
        {
            database = new SQLiteAsyncConnection(DependencyService.Get<IFileHelper>().GetLocalFilePath("TodoSQLite.db3"));
            database.CreateTableAsync<T>().Wait();
        }

        public Task<List<T>> GetItemsAsync()
        {
            return database.Table<T>().ToListAsync();
        }

        public Task<List<T>> GetItemsNotDoneAsync()
        {
            var tipo = typeof(T);
            return database.QueryAsync<T>("SELECT * FROM " + nameof(tipo) + " WHERE [Done] = 0");
        }

        public Task<T> GetItemAsync(int id)
        {
            return database.Table<T>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(T item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(T item)
        {
            return database.DeleteAsync(item);
        }
    }
}

