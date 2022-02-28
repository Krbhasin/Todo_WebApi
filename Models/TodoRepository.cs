using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoApi.Models
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoContext _context;

        public TodoRepository(TodoContext context)
        {
            _context = context;
            //Add(new TodoItems { Name = "Item1" });
        }

        public IEnumerable<TodoItems> GetAll()
        {
            return _context.TodoItems.ToList();
        }

        public void Add(TodoItems item)
        {
            _context.TodoItems.Add(item);
            _context.SaveChanges();
        }

        public TodoItems Find(long key)
        {
            return _context.TodoItems.FirstOrDefault(t => t.Key == key);
        }

        public void Remove(long key)
        {
            var entity = _context.TodoItems.First(t => t.Key == key);
            _context.TodoItems.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(TodoItems item)
        {
            _context.TodoItems.Update(item);
            _context.SaveChanges();
        }
    }
}