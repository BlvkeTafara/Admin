using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionSettings.Domain.Repository
{
    public interface IGenericRepository<T> where T : class 
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        

        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(int id);
        void RemoveRange(IEnumerable<T> entities);
    }
    
    }

