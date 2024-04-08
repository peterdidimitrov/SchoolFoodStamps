﻿
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

        public void Delete<T>(T entity) where T : class
        {
            DbSet<T>().Remove(entity);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await this.context.SaveChangesAsync();
        }

        public async Task<T?> GetByIdAsync<T>(object id) where T : class
        {
            return await DbSet<T>().FindAsync(id);
        }

        public async Task UpdateAsync<T>(T entity) where T : class
        {
            this.context.Update(entity);
            await this.context.SaveChangesAsync();
        }
    }
}
