using HansensTodo.Data;
using HansensTodo.Data;
using HansensTodo.Migrations;
using HansensTodo.Models;
using Microsoft.EntityFrameworkCore;


namespace HansensTodo.Repo
{
    public class HashRepo
    {
        public DatabaseContext _context;

        public HashRepo(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Hashed> GetHash(string UserEmailID)
        {
            return await _context.Set<Hashed>().FirstOrDefaultAsync(i => i.UserEmailId == UserEmailID);
        }

        public async Task<Hashed> Create(Hashed _hashed)
        {
            _context.TodoHash.Add(_hashed);
            await _context.SaveChangesAsync();
            return _hashed;
        }

        public async Task<Hashed> UpdateHash(Hashed _hashed)
        {
            _context.Entry(_hashed).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return _hashed;
        }

        public int CheckIfEmpty(string UserEmailID)
        {
            return _context.TodoHash.Where(c => c.UserEmailId == UserEmailID).Count();            
        }
    }
}
