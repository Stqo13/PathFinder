using PathFinder.Data.Repository.Interfaces;

namespace PathFinder.Data.Repository
{
    public class Repository<TType, TId> :IRepository<TType, TId>
        where TType : class
    {
        public void Add(TType item)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(TType item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TId id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(TId id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TType> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TType>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TType> GetAllAttached()
        {
            throw new NotImplementedException();
        }

        public TType GetById(TId id)
        {
            throw new NotImplementedException();
        }

        public Task<TType> GetByIdAsync(TId id)
        {
            throw new NotImplementedException();
        }

        public bool Update(TType item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(TType item)
        {
            throw new NotImplementedException();
        }
    }
}
