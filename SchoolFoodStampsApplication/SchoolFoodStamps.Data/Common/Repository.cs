
using Microsoft.EntityFrameworkCore;

namespace SchoolFoodStamps.Data.Common
{
    public class Repository : IRepository
    {
        private readonly DbContext context;

        public Repository(SchoolFoodStampsDbContext _context)
        {
            this.context = _context;
        }

        private DbSet<T> DbSet<T>() where T : class
        {
            return this.context.Set<T>();
        }

        public IQueryable<T> All<T>() where T : class
        {
            return this.DbSet<T>();
        }

        public IQueryable<T> AllReadOnly<T>() where T : class
        {
            return this.DbSet<T>().AsNoTracking();
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
            await DbSet<T>().AddAsync(entity);
        }

        public Task DeleteAsync<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await this.context.SaveChangesAsync();
        }

        public async Task<T?> GetByIdAsync<T>(Guid id) where T : class
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync<T>(T entity) where T : class
        {
            this.context.Update(entity);
            await this.context.SaveChangesAsync();
        }

        public async Task<T?> GetByIntIdAsync<T>(int id) where T : class
        {
            return await context.Set<T>().FindAsync(id);
        }
    }
}
