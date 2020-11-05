using EShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAPI.Configuration
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasDefaultValueSql("(newid())");

            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(10).IsUnicode(false);
            builder.Property(x => x.Message).IsRequired();
        }
    }
}
