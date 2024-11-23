using Microsoft.EntityFrameworkCore;
using Planify.Data;
using Planify.Models;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace Planify.Repositories
{
    public abstract partial class GenericRepository<T, TID> : GenericCRUDRepository<T, TID>
        where T : BaseModel<TID>
    {
        private readonly ProjectContext _context;
        protected DbSet<T> Entities => _context.Set<T>();
        protected GenericRepository(ProjectContext context) => _context = context;
    }

    public abstract partial class GenericRepository<T, TID>
    {
        public async Task<T> Create(T entity) =>
            (await Entities.AddAsync(entity)).Entity;

        public IQueryable<T> GetAll() => Entities;

        public Task<T?> GetById(TID id) =>
            Entities.FirstOrDefaultAsync(e => e.Id!.Equals(id));

        public async Task<bool> HardDelete(TID id)
        {
            var res = await Entities.IgnoreQueryFilters()
                .FirstOrDefaultAsync(e => e.Id!.Equals(id));

            if (res is null)
                return false;

            return true;
        }

        public async Task<bool> SoftDelete(TID id)
        {
            T? existingEntity = await GetById(id);
            if (existingEntity is null)
                return false;

            existingEntity.IsDeleted = true;
            existingEntity.DeletedTimeUTC = DateTime.UtcNow;

            return true;
        }

        public async Task<bool> Updated(T entity)
        {
            var ExistingEntity = await GetById(entity.Id!);
            if (ExistingEntity is null)
                return false;

            ExistingEntity.LastUpdatedUTC = DateTime.UtcNow;
            Entities.Update(entity);
            return true;
        }
    }

}
