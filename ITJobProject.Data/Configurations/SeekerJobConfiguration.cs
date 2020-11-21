using ITJobProject.Data.Entities;
using ITJobProject.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITJobProject.Data.Configurations
{
    public class SeekerJobConfiguration : IEntityTypeConfiguration<SeekerJob>
    {
        public void Configure(EntityTypeBuilder<SeekerJob> builder)
        {
            builder.ToTable("SeekerJobs");
            builder.HasKey(x => new { x.SeekerId, x.JobId });
            builder.Property(x => x.ApplyDate).IsRequired(true);
            builder.Property(x => x.CVLink);
            builder.Property(x => x.Status).HasDefaultValue(Status.Approved);
            builder.Property(x => x.CreatedDate).HasDefaultValue(new DateTime());
            builder.Property(x => x.CreatedBy).HasDefaultValue("TDNAM");
            builder.Property(x => x.ModifiedDate);
            builder.Property(x => x.ModifiedBy);
            builder.HasOne(s => s.Seeker).WithMany(sj => sj.SeekerJobs)
                .HasForeignKey(sj => sj.SeekerId);
            builder.HasOne(s => s.Job).WithMany(sj => sj.SeekerJobs)
                .HasForeignKey(sj => sj.JobId);
        }
    }
}
