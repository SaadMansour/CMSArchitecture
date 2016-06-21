using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Core.Repositories
{
    public class UserRoleRepository : BaseRepository<User_Role>, IUserRoleRepository
    {
        public UserRoleRepository(CMSDbContext dbContext)
            : base(dbContext)
        { }
    }
}
