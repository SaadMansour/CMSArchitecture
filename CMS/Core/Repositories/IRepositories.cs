using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Core.Repositories
{
    public interface IContactRepository : IBaseRepository<Contact> { }

    public interface IEncounterRepository : IBaseRepository<Encounter> { }

    public interface IPatientRepository : IBaseRepository<Patient> {
        IEnumerable<Patient> GetPatientsByFirstName(string firstName);
    }

    public interface IRoleRepository : IBaseRepository<Role> { }

    public interface IUserRepository : IBaseRepository<User> { }

    public interface IUserRoleRepository : IBaseRepository<User_Role> { }
}
