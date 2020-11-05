using EShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAPI.Configuration
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(x => x.Id);builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ProductId).HasDefaultValueSql("(newid())");
            builder.Property(x => x.Price).HasColumnType("decimal(18, 2)");
            builder.Property(x => x.DateCreated).HasColumnType("datetime");
            builder.Property(x => x.UserId).HasMaxLength(450).IsRequired();
            builder.HasOne(x => x.Product).WithMany(x => x.Carts).HasForeignKey(x => x.ProductId);
            
      
        }
    }
}
