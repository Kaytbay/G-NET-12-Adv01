using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv01
{
    internal interface IRepository<T> 
    {

        //Add
        void Add(T entity);
        //Delete
        void Delete(int id);
        //GetById
        T GetById(int id);
        //GetAll
        List<T> GetAll();
    }
}
