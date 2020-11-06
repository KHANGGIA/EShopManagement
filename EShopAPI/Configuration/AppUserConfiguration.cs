using EShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAPI.Configuration
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");
            builder.Property(x => x.Id).HasMaxLength(450);builder.Property(x => x.UserName).HasMaxLength(450);
            builder.Property(x => x.FirstName).HasMaxLength(450); builder.Property(x => x.LastName).HasMaxLength(450);
            builder.Property(x => x.DoB).HasDefaultValueSql("getdate()");
        }
    }
}
