using ITJobProject.Data.Entities;
using ITJobProject.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITJobProject.Data.Configurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Companies");
            builder.HasKey(x => x.CompanyId);
            builder.Property(x => x.CompanyName).IsRequired(true);
            builder.Property(x => x.CompanySize);
            builder.Property(x => x.Address);
            builder.Property(x => x.Introduction);
            builder.Property(x => x.Image);
            builder.Property(x => x.WorkingDay);
            builder.Property(x => x.TypeBusiness).HasDefaultValue(TypeBusiness.outsource);
            builder.Property(x => x.CreatedDate).HasDefaultValue(new DateTime());
            builder.Property(x => x.CreatedBy).HasDefaultValue("TDNAM");
            builder.Property(x => x.ModifiedDate);
            builder.Property(x => x.ModifiedBy);
        }
    }
}
