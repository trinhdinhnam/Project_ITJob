using ITJobProject.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITJobProject.Data.Configurations
{
    public class RecruiterConfiguration : IEntityTypeConfiguration<Recruiter>
    {
        public void Configure(EntityTypeBuilder<Recruiter> builder)
        {
            builder.ToTable("Recruiters");
            builder.HasKey(x => x.RecruiterId);
            builder.Property(x => x.RecruiterName).IsRequired(true);
            builder.Property(x => x.Email);
            builder.Property(x => x.Phone);
            builder.Property(x => x.DateOfBirth);
            builder.Property(x => x.Gender);
            builder.Property(x => x.Address);
            builder.Property(x => x.Password).IsRequired(true);
            builder.Property(x => x.CreatedDate).HasDefaultValue(new DateTime());
            builder.Property(x => x.CreatedBy).HasDefaultValue("TDNAM");
            builder.Property(x => x.ModifiedDate);
            builder.Property(x => x.ModifiedBy);
            builder.HasOne(x => x.RecruiterLevel).WithMany(x => x.Recruiters)
                .HasForeignKey(x => x.RecruiterLevelId);

        }
    }
}
