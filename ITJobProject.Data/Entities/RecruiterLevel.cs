using System;
using System.Collections.Generic;
using System.Text;

namespace ITJobProject.Data.Entities
{
    public class RecruiterLevel
    {
        public Guid RecruiterLevelId { get; set; }
        public string RecruiterLevelName { get; set; }
        public decimal Price { get; set; }
        public int PostNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public List<Recruiter> Recruiters { get; set; }
    }
}
