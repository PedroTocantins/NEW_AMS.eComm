using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.eComm.Domain.Core.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {
        Task Add(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetAllById(Guid id);
        Task<T> Post();
        void Delete(Guid id);
    }
}
