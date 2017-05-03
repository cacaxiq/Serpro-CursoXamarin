using System;

namespace TodoREST
{
    public class TodoItem
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Notes { get; set; }

        public bool Done { get; set; }
    }
}
