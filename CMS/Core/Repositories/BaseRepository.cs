using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CMS.Models;
using System.Threading.Tasks;

namespace CMS.Core.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private CMSDbContext cmsDbContext;

        private readonly DbSet<T> dbSet;

        public BaseRepository(CMSDbContext dbContext) {
            cmsDbContext = dbContext;
            dbSet = cmsDbContext.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.AsEnumerable();
        }

        public virtual void Add(T model)
        {
            dbSet.Add(model);
        }

        public virtual IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }

        public virtual void Commit()
        {
            cmsDbContext.SaveChanges();
        }
    }
}
