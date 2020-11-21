using ITJobProject.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITJobProject.Data.Configurations
{
    public class RecruiterLevelConfiguration : IEntityTypeConfiguration<RecruiterLevel>
    {
        public void Configure(EntityTypeBuilder<RecruiterLevel> builder)
        {
            builder.ToTable("RecruiterLevels");
            builder.HasKey(x => x.RecruiterLevelId);
            builder.Property(x => x.RecruiterLevelName).IsRequired(true);
            builder.Property(x => x.Price);
            builder.Property(x => x.PostNumber);
            builder.Property(x => x.RecruiterLevelId);
            builder.Property(x => x.CreatedDate).HasDefaultValue(new DateTime());
            builder.Property(x => x.CreatedBy).HasDefaultValue("TDNAM");
            builder.Property(x => x.ModifiedDate);
            builder.Property(x => x.ModifiedBy);
        }
    }
}
