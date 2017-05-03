using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Todo.Data;

namespace Todo
{
    public class TodoItemDatabase : DataServiceBase<TodoItem>, IDataServiceBase<TodoItem>
    {
    }
}

