using HansensTodo.Data;
using HansensTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace HansensTodo.Repo
{
    public class TodoRepo
    {
        public DatabaseContext _context;

        public TodoRepo(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Todo>> GetAllItem(string UserEmailId)
        {
            List<Todo> TodoList = await _context.Todos.Where(u => u.UserEmailId == UserEmailId).ToListAsync();
            return TodoList;
        }

        public async Task<Todo> GetSingle(int Id)
        {
            return await _context.Todos.FindAsync(Id);
        }

        public async Task<Todo> DeleteItem(int Id)
        {
            var item = _context.Todos.Find(Id);
            if(item != null)
            {
                _context.Todos.Remove(item);
                await _context.SaveChangesAsync();
            }
            return item;
        }

        public async Task<Todo> CreateItem(Todo _todo)
        {
            _context.Todos.Add(_todo);
            await _context.SaveChangesAsync();
            return null;
        }
    }
}
