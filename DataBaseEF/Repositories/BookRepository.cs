using DataBaseEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEF.Repositories
{
    public class BookRepository : Repository<BKS_Books>
    {
        protected readonly DbContext _context;
        public BookRepository(DbContext context) : base(context)
        {
           
        }
        
    }
}
