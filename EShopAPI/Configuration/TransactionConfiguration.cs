using EShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAPI.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");
            builder.HasKey(x => x.Id);builder.Property(x => x.Id).HasDefaultValueSql("(newid())");
            builder.Property(x => x.ExternalTransaction).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Fee).HasColumnType("decimal(18,2)");
            builder.Property(x => x.Amount).HasColumnType("decimal(18,2)");
            builder.Property(x => x.TransactionDate).HasColumnType("datetime");

            builder.HasOne(x => x.AppUser).WithMany(x => x.Transactions).HasForeignKey(x => x.UserId);

        }
    }
}
