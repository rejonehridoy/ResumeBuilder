using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ResumeBuilderDbContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(ResumeBuilderDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await this.GetAsync(id);
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public async Task<T> GetAsync(int id)
        {
            return await entities.FindAsync(id);
        }

        public ResumeBuilderDbContext GetContext()
        {
            return context;
        }
        public async Task<List<T>> GetAllAsync()
        {
            return await entities.ToListAsync();
        }

        public async Task InsertAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            await entities.AddAsync(entity);
            context.SaveChanges();
        }

        public async Task RemoveAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
