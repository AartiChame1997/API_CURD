using API_CURD.Data;
using API_CURD.Infrastrcture;
using API_CURD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CURD.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context; 
        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public Task Add(ProductDemo entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductDemo entity)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDemo> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDemo>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDemo> GetAllProduct()
        {
            var res = _context.productDemos.ToList();
            return res;
        }

        public void Update(ProductDemo entity)
        {
            throw new NotImplementedException();
        }
    }
}
