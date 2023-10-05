using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class     
    {
        void insert(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
        List<T> GetAll();
        T GetByID(int id);
    }
    
}
