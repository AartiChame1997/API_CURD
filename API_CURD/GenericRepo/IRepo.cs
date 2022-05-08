using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CURD.GenericRepo
{
    public interface IRepo<T> where T:class
    {
        IEnumerable<T> Getdata();
        T GetDataById(int id);
        void AddData(T entity);
        void Delete(int id);
        void Update(T entity);

    }
}
