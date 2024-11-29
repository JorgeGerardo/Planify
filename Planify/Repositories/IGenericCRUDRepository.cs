using System;
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
        Task<T?> GetById(TID id);
        Task<bool> Exist(TID id);
        Task<bool> ExistAsync(Expression<Func<T, bool>> condition);

        void Updated(T entity);
        Task<bool> SoftDelete(TID id);
        Task<bool> HardDelete(TID id);

        Task<int> Save();
    }
}
