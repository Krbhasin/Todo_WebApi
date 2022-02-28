using System.Collections.Generic;

namespace TodoApi.Models
{
    public interface ITodoRepository
    {
        void Add(TodoItems item);
        IEnumerable<TodoItems> GetAll();
        TodoItems Find(long key);
        void Remove(long key);
        void Update(TodoItems item);
    }
}