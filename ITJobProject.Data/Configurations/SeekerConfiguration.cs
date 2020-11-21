using ITJobProject.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITJobProject.Data.Configurations
{
    public class SeekerConfiguration : IEntityTypeConfiguration<Seeker>
    {
        public void Configure(EntityTypeBuilder<Seeker> builder)
        {
            builder.ToTable("Seekers");
            builder.HasKey(x => x.SeekerId);
            builder.Property(x => x.SeekerName).IsRequired(true);
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
        }
    }
}
