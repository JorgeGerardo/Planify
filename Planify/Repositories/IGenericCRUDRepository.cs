using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Planify.Repositories
{
    public interface IGenericCRUDRepository<T, TID>
    {
        public string[] _NavigationProperties { get; set; }
        Task<T> Create(T entity);

        IQueryable<T> GetAll();
        IQueryable<T> GetAllWithoutFiltters();
        IQueryable<T> GetDeletedEntities();
        Task<T?> GetById(TID id);
        Task<bool> Exist(TID id);
        Task<bool> ExistAsync(Expression<Func<T, bool>> condition);
        Task<T?> EntityWithAsync(Expression<Func<T, bool>> condition);
        Task<IEnumerable<T>> EntitiesWithAsync(Expression<Func<T, bool>> condition);

        void Updated(T entity);
        Task<bool> SoftDelete(TID id);
        Task<bool> RemoveSoftDelete(TID id);
        Task<bool> HardDelete(TID id);

        Task<int> Save();
    }
}
