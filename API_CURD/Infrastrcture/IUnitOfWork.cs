using API_CURD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CURD.Infrastrcture
{
    public interface IUnitOfWork
    {
        IOrderRepositorycs Orders { get; }
        IProductRepository Products { get; }
        int Complete();
    }
}
