using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Core.Repositories
{
    public class EncounterRepository : BaseRepository<Encounter>, IEncounterRepository
    {
        public EncounterRepository(CMSDbContext dbContext)
            : base(dbContext)
        { }
    }
}
