using API_CURD.Data;
using API_CURD.Infrastrcture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CURD.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        public IOrderRepositorycs Orders { get; }
        public IProductRepository Products
        {
            get;
        }

        public UnitOfWork(DataContext context,IOrderRepositorycs orderRepositorycs,IProductRepository productRepository)
        {
            _context = context;
            Orders = orderRepositorycs;
            Products = productRepository;
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
