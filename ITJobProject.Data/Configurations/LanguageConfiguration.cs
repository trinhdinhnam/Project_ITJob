using ITJobProject.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITJobProject.Data.Configurations
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Languages");
            builder.HasKey(x => x.LanguageId);
            builder.Property(x => x.LanguageName).IsRequired(true);
            builder.Property(x => x.Description);
            builder.Property(x => x.CreatedDate).HasDefaultValue(new DateTime());
            builder.Property(x => x.CreatedBy).HasDefaultValue("TDNAM"); 
            builder.Property(x => x.ModifiedDate);
            builder.Property(x => x.ModifiedBy);
        }
    }
}
