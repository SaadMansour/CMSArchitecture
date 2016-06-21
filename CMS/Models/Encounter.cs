using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models
{
    public class Encounter : BaseModel
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        #region Relationships
        /// <summary>
        /// One-to-many relationship: a patient has many encounter, and an encounter 
        /// has one patient. Encounter is the dependent entity (child).
        /// </summary>
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        #endregion
    }
}
