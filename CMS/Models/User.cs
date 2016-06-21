using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models
{
    public class User : BaseModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// Many-to-many relationship with roles
        /// </summary>
        public List<User_Role> UserRoles { get; set; }
    }
}
