using ITJobProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITJobProject.Data.Entities
{
    public class Company
    {
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Introduction { get; set; }
        public string Image { get; set; }
        public string WorkingDay { get; set; }
        public int CompanySize { get; set; }
        public TypeBusiness TypeBusiness { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public List<Job> Jobs { get; set; }
    }
}
