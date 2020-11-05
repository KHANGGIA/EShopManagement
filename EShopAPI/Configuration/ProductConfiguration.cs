using EShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAPI.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("(newid())");
            builder.Property(x => x.OriginalPrice).HasColumnType("decimal(18, 2)");
            builder.Property(x => x.Price).HasColumnType("decimal(18, 2)");
            builder.Property(x => x.DateCreated).HasColumnType("datetime");
            builder.Property(x => x.StockQuantity).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);
        }
    }
}
