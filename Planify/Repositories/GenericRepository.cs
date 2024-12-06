using Microsoft.EntityFrameworkCore;
using Planify.Data;
using Planify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Planify.Repositories
{
    public abstract partial class GenericRepository<T, TID> : IGenericCRUDRepository<T, TID>
        where T : DbBaseModel<TID>
    {
        private readonly ProjectContext _context;
        protected DbSet<T> Entities => _context.Set<T>();
        private IQueryable<T> _entitiesNav;

        public virtual string[] _NavigationProperties { get => NavProp; set => NavProp = value; }
        private string[] NavProp = Array.Empty<string>();

        protected GenericRepository(ProjectContext context)
        {
            _context = context;
            _entitiesNav = Entities;

            foreach (var include in _NavigationProperties)
                _entitiesNav = _entitiesNav.Include(include);
        }

        public async Task<int> Save() =>
                await _context.SaveChangesAsync();

    }

    //Basic CRUD
    public abstract partial class GenericRepository<T, TID>
    {
        public async Task<T> Create(T entity) =>
            (await Entities.AddAsync(entity)).Entity;

        public IQueryable<T> GetAll() => _entitiesNav;

        public Task<T?> GetById(TID id) =>
            _entitiesNav.FirstOrDefaultAsync(e => e.Id!.Equals(id));

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

        public async Task<bool> RemoveSoftDelete(TID id)
        {
            T? existingEntity =
                await _entitiesNav.IgnoreQueryFilters().FirstOrDefaultAsync(e => e.Id!.Equals(id));
            if (existingEntity is null)
                return false;

            existingEntity.IsDeleted = false;
            existingEntity.LastUpdatedUTC = DateTime.UtcNow;

            return true;
        }

        public void Updated(T entity)
        {
            entity.LastUpdatedUTC = DateTime.UtcNow;
            Entities.Update(entity);
        }

        public async Task<bool> Exist(TID id) =>
            await Entities.AnyAsync(e => e.Id!.Equals(id));

    }

    //Filters:
    public abstract partial class GenericRepository<T, TID>
    {
        public async Task<bool> ExistAsync(Expression<Func<T, bool>> condition) =>
            await _entitiesNav.AnyAsync(condition);

        public async Task<T?> GetFirstByConditionAsync(Expression<Func<T, bool>> condition) =>
            await _entitiesNav.FirstOrDefaultAsync(condition);

        public async Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> condition) =>
            await _entitiesNav.Where(condition).ToListAsync();

        public IQueryable<T> GetAllNoFilters() => 
            _entitiesNav.IgnoreQueryFilters();

        public IQueryable<T> GetDeletedEntities() => 
            _entitiesNav.IgnoreQueryFilters().Where(e => e.IsDeleted);

    }
}
