using EShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAPI.Configuration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Languages");
            builder.HasKey(e => e.LanguageId);
            builder.Property(x => x.LanguageId).IsRequired().IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Name) .IsRequired().HasMaxLength(50);
        }
    }
}
