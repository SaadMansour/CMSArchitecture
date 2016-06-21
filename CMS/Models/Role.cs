using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models
{
    public class Role : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// Many-to-many relationship with users.
        /// </summary>
        public List<User_Role> UserRoles { get; set; }
    }
}
