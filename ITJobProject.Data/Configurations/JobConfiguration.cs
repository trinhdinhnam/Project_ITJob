using ITJobProject.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITJobProject.Data.Configurations
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.ToTable("Jobs");
            builder.HasKey(x => x.JobId);
            builder.Property(x => x.JobName).IsRequired(true);
            builder.Property(x => x.Possition);
            builder.Property(x => x.Require);
            builder.Property(x => x.Description);
            builder.Property(x => x.Salary);
            builder.Property(x => x.StartDateApply);
            builder.Property(x => x.EndDateApply);
            builder.Property(x => x.Address);
            builder.Property(x => x.CreatedDate).HasDefaultValue(new DateTime());
            builder.Property(x => x.CreatedBy).HasDefaultValue("TDNAM"); 
            builder.Property(x => x.ModifiedDate);
            builder.Property(x => x.ModifiedBy);
            builder.HasOne(c => c.Company ).WithMany(j=>j.Jobs)
                .HasForeignKey(j=>j.CompanyId);
            builder.HasOne(c => c.Admin).WithMany(j => j.Jobs)
               .HasForeignKey(j => j.AdminId);
            builder.HasOne(c => c.Language).WithMany(j => j.Jobs)
               .HasForeignKey(j => j.LanguageId);
            builder.HasOne(c => c.Recruiter).WithMany(j => j.Jobs)
               .HasForeignKey(j => j.RecruiterId);
        }
    }
}
