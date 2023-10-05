using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
       
    {
       CarBookContext context = new CarBookContext();
   
       
        public void Delete(T Entity)
        {
           context.Set<T>().Remove(Entity);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
            

        }

        public T GetByID(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void insert(T Entity)
        {
            context.Set<T>().Add(Entity);    
            context.SaveChanges();  
        }

        public void Update(T Entity)
        {
            context.Set<T>().Update(Entity);
            context.SaveChanges();
        }
    }
}
