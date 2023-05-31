using AMS.eComm.Domain.Core.Entities;
using AMS.eComm.Domain.Core.Interfaces.Repository;
using AMS.eComm.Domain.Core.Interfaces.Sevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.eComm.Services.Service
{
    public class ProductService : IBaseService<Product>
    {
        private readonly IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task Add(Product entity)
        {
            await _repository.Add(entity);

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
