using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models
{
    public class Contact : BaseModel
    {
        public string Email { get; set; }
        public string Address { get; set; }

        #region Relationships

        /// <summary>
        /// One-to-one relationship with Patient. Patient is the Principal entity.
        /// </summary>
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        #endregion
    }
}
