using SQLite;

namespace Todo.Models
{
    public class ModelBase
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
    }
}
