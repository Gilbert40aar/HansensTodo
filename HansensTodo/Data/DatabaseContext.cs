using HansensTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace HansensTodo.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {

        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<Hashed> TodoHash { get; set; }
    }
}
