using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models
{
    public class Patient : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        #region Relationships
        /// <summary>
        /// One-to-many relationship: a patient has many encounter, and an encounter 
        /// has one patient. Patient is the principal entity (parent).
        /// </summary>
        public List<Encounter> Encounters { get; set; }

        /// <summary>
        /// One-to-one relationship with contact. Patient is the Principal entity.
        /// </summary>
        public Contact Contact { get; set; }
        #endregion
    }
}
