using Microsoft.EntityFrameworkCore;
using PathFinder.Data.Repository.Interfaces;

namespace PathFinder.Data.Repository
{
    public class Repository<TType, TId> : IRepository<TType, TId>
        where TType : class
    {
        private readonly PathFinderDbContext context;
        private readonly DbSet<TType> dbSet;

        public Repository(PathFinderDbContext context)
        {
            this.context = context;
            this.dbSet = this.context.Set<TType>();
        }

        public TType GetById(TId id)
        {
            TType? entity = this.dbSet
                .Find(id);

            if (entity == null)
            {
                throw new NullReferenceException("Entity was null!");
            }

            return entity;
        }

        public async Task<TType> GetByIdAsync(TId id)
        {
            TType? entity = await this.dbSet
                .FindAsync(id);

            if (entity == null)
            {
                throw new NullReferenceException("Entity was null!");
            }

            return entity;
        }

        public ICollection<TType> GetAll()
        {
            return this.dbSet.ToList();
        }

        public async Task<ICollection<TType>> GetAllAsync()
        {
            return await this.dbSet.ToListAsync();
        }

        public IQueryable<TType> GetAllAttached()
        {
            return this.dbSet.AsQueryable();
        }

        public void Add(TType item)
        {
            this.dbSet.Add(item);
            this.context.SaveChanges();
        }

        public async Task AddAsync(TType item)
        {
            await this.dbSet.AddAsync(item);
            await this.context.SaveChangesAsync();
        }

        public bool Delete(TId id)
        {
            TType entity = this.GetById(id);

            if (entity == null)
            {
                return false;
            }

            this.dbSet.Remove(entity);
            this.context.SaveChanges();

            return true;
        }

        public async Task<bool> DeleteAsync(TId id)
        {
            TType entity = await this.GetByIdAsync(id);

            if (entity == null)
            {
                return false;
            }

            this.dbSet.Remove(entity);
            await this.context.SaveChangesAsync();

            return true;
        }

        public bool Update(TType item)
        {
            try
            {
                this.dbSet.Attach(item);
                this.context.Entry(item).State = EntityState.Modified;
                this.context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(TType item)
        {
            try
            {
                this.dbSet.Attach(item);
                this.context.Entry(item).State = EntityState.Modified;
                await this.context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
