using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CMS.Models;
using System.Threading.Tasks;

namespace CMS.Core.Repositories
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        IEnumerable<T> GetAll();

        void Add(T model);

        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);

        void Commit();
    }
}
