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
    public class BlogPostConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.ToTable("BlogPosts");
            builder.HasKey(x => x.BlogId); 
            builder.Property(x => x.BlogId).HasDefaultValueSql("(newid())");
            builder.Property(x => x.Title).HasMaxLength(450);
            builder.Property(x => x.DateCreated).HasColumnType("datetime");
            builder.Property(x => x.UserId).HasMaxLength(450).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.Image).HasMaxLength(500);
            builder.Property(x => x.BlogCategoryId).HasDefaultValueSql("(newid())");

            builder.HasOne(x => x.BlogCategory).WithMany(x => x.BlogPosts).HasForeignKey(x => x.BlogCategoryId);
          
        }
    }
}
