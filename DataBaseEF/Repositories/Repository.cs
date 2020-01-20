using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEF.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext _Entities;
        protected readonly DbSet<T> DbSet;
        public Repository(DbContext context)
        {
            _Entities = context;
            DbSet = context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }
    }
}
