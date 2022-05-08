using API_CURD.Data;
using API_CURD.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CURD.GenericRepo
{
    public class Repository : IRepo<Project>,IRepo<Developer>
    {
        private readonly DataContext _Context;

        public Repository(DataContext context)
        {
            _Context = context;
        }

        public void AddData(Project entity)
        {
            _Context.project.Add(entity);
            _Context.SaveChanges();
        }

        public void AddData(Developer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> Getdata()
        {
            var res = _Context.project.ToList();
            return res;
        }

        public Project GetDataById(int id)
        {
            var res = _Context.project.Where(x => x.Id == id).FirstOrDefault();
            return res;
        }

        public void Update(Project entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Developer entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Developer> IRepo<Developer>.Getdata()
        {
            throw new NotImplementedException();
        }

        Developer IRepo<Developer>.GetDataById(int id)
        {
            throw new NotImplementedException();
        }
    }

   
}
// private readonly DataContext _Context;
// private readonly DbSet<T> entities;


//public Repository(DataContext context)
// {
//     _Context = context;
//     entities = _Context.Set<T>();

// }

//public void AddData(T entity)
//{
//    entities.Add(entity);

//}

//public void Delete(int id)
//{
//    throw new NotImplementedException();
//}

//public IEnumerable<T> Getdata()
//{
//    return entities.ToList();
//}



//public T GetDataById(int id)
//{
//    return entities.Find(id);
//}

//public void Update(T entity)
//{
//    throw new NotImplementedException();
//}
