using EShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedObject.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAPI.Configuration
{
    public class BlogCategoryConfiguration : IEntityTypeConfiguration<BlogCategory>
    {
        public void Configure(EntityTypeBuilder<BlogCategory> builder)
        {
            builder.ToTable("BlogCategories");
            builder.HasKey(x => x.BlogCategoryId);
            builder.Property(x => x.BlogCategoryId).HasDefaultValueSql("(newid())");
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.BlogCategoryName).HasMaxLength(250);

        }
    }
}
