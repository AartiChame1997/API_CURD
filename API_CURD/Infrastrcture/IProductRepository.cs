using API_CURD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CURD.Infrastrcture
{
    public interface IProductRepository:IGenericRepository<ProductDemo>
    {

        IEnumerable<ProductDemo> GetAllProduct();

    }
}
