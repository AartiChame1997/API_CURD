using API_CURD.Data;
using API_CURD.Infrastrcture;
using API_CURD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CURD.Repository
{
    public class OrderRepository : IOrderRepositorycs
    {

        private readonly DataContext _context;

        public OrderRepository(DataContext context)
        {
            _context = context;
        }
        public Task Add(OrderDemo entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(OrderDemo entity)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDemo> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderDemo>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderDemo>> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public void Update(OrderDemo entity)
        {
            throw new NotImplementedException();
        }
    }
}
