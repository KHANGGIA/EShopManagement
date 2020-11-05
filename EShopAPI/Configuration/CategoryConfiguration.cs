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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.CategoryId);builder.Property(x => x.CategoryId).HasDefaultValueSql("(newid())");
            builder.Property(x => x.ParentId).HasDefaultValueSql("(newid())");
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
