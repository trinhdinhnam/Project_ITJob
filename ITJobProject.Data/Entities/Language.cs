using System;
using System.Collections.Generic;
using System.Text;

namespace ITJobProject.Data.Entities
{
    public class Language
    {
        public Guid LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public List<Job> Jobs { get; set; }
    }
}
