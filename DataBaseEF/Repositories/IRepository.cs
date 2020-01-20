using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEF.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(int id);
    }
}
