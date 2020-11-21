using ITJobProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITJobProject.Data.Entities
{
    public class Seeker
    {
        public Guid SeekerId { get; set; }
        public string SeekerName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public List<SeekerJob> SeekerJobs { get; set; }
    }
}
