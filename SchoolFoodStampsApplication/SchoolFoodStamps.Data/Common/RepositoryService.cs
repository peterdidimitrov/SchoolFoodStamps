
using Microsoft.EntityFrameworkCore;

namespace SchoolFoodStamps.Data.Common
{
    public class RepositoryService : IRepositoryService
    {
        private readonly DbContext context;

        public RepositoryService(SchoolFoodStampsDbContext _context)
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
    }
}
