using Microsoft.EntityFrameworkCore;
using Planify.Data;
using Planify.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Planify.Repositories
{
    public abstract partial class GenericRepository<T, TID> : IGenericCRUDRepository<T, TID>
        where T : BaseModel<TID>
    {
        private readonly ProjectContext _context;
        protected DbSet<T> Entities => _context.Set<T>();
        protected GenericRepository(ProjectContext context) => _context = context;

        public async Task<int> Save()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
            }
            return 0;
        }
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
            T? res = await Entities.IgnoreQueryFilters()
                .FirstOrDefaultAsync(e => e.Id!.Equals(id));

            if (res is null)
                return false;

            Entities.Remove(res);

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

        public void Updated(T entity)
        {
            //T? ExistingEntity = await GetById(entity.Id!);
            //if (ExistingEntity is null)
            //    return false;

            //Entities.Attach(entity);

            entity.LastUpdatedUTC = DateTime.UtcNow;
            Entities.Update(entity);
        }
    }

}
