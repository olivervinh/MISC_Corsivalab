using API.Data;
using API.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace API.Services.Base
{
    public interface IBaseService<T> where T : EntityBase
    {
        public Task<T> Create(T param);
        public Task<T> GetByFirstVariable(int Id);
        public Task<T> GetByLastInsertedId();
        public Task<IEnumerable<T>> GetAll();
        public Task<int> CountAll();
        public Task<T> Update(T param);
        public Task<bool> UpdateSoftDelete(int Id);
        public Task<bool> DeletebyFirstVariable(int Id);
    }
    public class BaseService<T> : IBaseService<T> where T : EntityBase
    {
        public AppDbContext _context;
        public DbSet<T> dbSet;
        public BaseService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<T> Create(T param)
        {
            dbSet.Add(param);
            await _context.SaveChangesAsync();
            return param;
        }
        public async Task<T> GetByFirstVariable(int Id)
        {
            return await dbSet.FindAsync(Id);
        }
        public async Task<T> GetByLastInsertedId()
        {
            return await dbSet.LastOrDefaultAsync();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }
        public async Task<int> CountAll()
        {
            return await dbSet.CountAsync();
        }
        public async Task<T> Update(T param)
        {
            dbSet.Update(param);
            await _context.SaveChangesAsync();
            return param;
        }
        public async Task<bool> UpdateSoftDelete(int Id)
        {
            var model = await dbSet.FindAsync(Id);
            model.SoftDelete = true;
            dbSet.Update(model);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeletebyFirstVariable(int Id)
        {
            var model = await dbSet.FindAsync(Id);
            dbSet.Remove(model);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
