using AMS.eComm.Domain.Core.Entities;
using AMS.eComm.Domain.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.eComm.Infra.Data.Repository
{
    public class ProductRepository : IProduct
    {
        public Task Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetAllById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Post()
        {
            throw new NotImplementedException();
        }
    }
}
