using ITJobProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITJobProject.Data.Entities
{
    public class Recruiter
    {
        public Guid RecruiterId { get; set; }
        public string RecruiterName { get; set; }
        public string Phone { get; set; }

        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public Guid RecruiterLevelId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public RecruiterLevel RecruiterLevel { get; set; }
        public List<Job> Jobs { get; set; }
    }
}
