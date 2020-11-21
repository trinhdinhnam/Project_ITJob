using System;
using System.Collections.Generic;
using System.Text;

namespace ITJobProject.Data.Entities
{
    public class Admin
    {
        public Guid AdminId { get; set; }
        public string AdminName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public List<Job> Jobs { get; set; }
    }
}
