using SQLite;
using Todo.Models;

namespace Todo
{
    public class TodoItem : ModelBase
    {
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }
    }
}

