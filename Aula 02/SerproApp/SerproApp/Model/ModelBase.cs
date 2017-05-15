using SQLite;

namespace Serpro.Model
{
    public class ModelBase
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
    }
}