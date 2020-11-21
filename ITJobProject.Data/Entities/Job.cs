using System;
using System.Collections.Generic;
using System.Text;

namespace ITJobProject.Data.Entities
{
    public class Job
    {
        public Guid JobId { get; set; }
        public string JobName { get; set; }
        public string Possition { get; set; }
        public Guid LanguageId { get; set; }
        public string Require {get;set; }
        public string Description { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDateApply { get; set; }
        public DateTime EndDateApply { get; set; }
        public Guid CompanyId { get; set; }
        public Guid AdminId { get; set; }
        public Guid RecruiterId { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public List<SeekerJob> SeekerJobs { get; set; }
        public Recruiter Recruiter { get; set; }
        public Company Company { get; set; }
        public Admin Admin { get; set; }
        public Language Language { get; set; }
    }
}
