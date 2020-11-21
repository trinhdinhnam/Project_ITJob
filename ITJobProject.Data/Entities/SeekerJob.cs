using ITJobProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITJobProject.Data.Entities
{
    public class SeekerJob
    {
        public Guid SeekerId { get; set; }
        public Guid JobId { get; set; }
        public DateTime ApplyDate { get; set; }
        public string CVLink { get; set; }
        public Status Status { get; set; }
        public Seeker Seeker { get; set; }
        public Job Job { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
