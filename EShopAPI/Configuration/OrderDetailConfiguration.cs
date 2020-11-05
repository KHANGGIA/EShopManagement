using EShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAPI.Configuration
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(x => x.Id); builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x=>x.OrderId).HasDefaultValueSql("(newid())");
            builder.Property(x => x.ProductId).HasDefaultValueSql("(newid())");

            builder.Property(x => x.Price).HasColumnType("decimal(18, 2)");
            
            builder.HasOne(x => x.Order).WithMany(x => x.OrderDetails).HasForeignKey(x => x.OrderId);
            builder.HasOne(x => x.Product).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductId);
        }
    }
}
