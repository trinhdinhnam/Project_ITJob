using ITJobProject.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITJobProject.Data.Configurations
{
    public class AdminConfigguration : IEntityTypeConfiguration<Admin>
    {
            public void Configure(EntityTypeBuilder<Admin> builder)
            {
               builder.ToTable("Admins");
            builder.HasKey(x => x.AdminId);
            builder.Property(x => x.AdminName).IsRequired(true);
            builder.Property(x => x.Email);
            builder.Property(x => x.Phone);
            builder.Property(x => x.Password).IsRequired(true);
            builder.Property(x => x.CreatedDate).HasDefaultValue(new DateTime());
            builder.Property(x => x.CreatedBy).HasDefaultValue("TDNAM");
            builder.Property(x => x.ModifiedDate);
            builder.Property(x => x.ModifiedBy);
             }
    }
}
