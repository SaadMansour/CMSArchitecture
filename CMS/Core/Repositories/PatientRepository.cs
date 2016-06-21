using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Core.Repositories
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        public PatientRepository(CMSDbContext dbContext)
            : base(dbContext)
        { }

        public IEnumerable<Patient> GetPatientsByFirstName(string firstName)
        {
            return this.FindBy(p => p.FirstName == firstName);
        }
    }
}
