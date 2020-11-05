using EShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShopAPI.Configuration
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");
            builder.HasKey(x => new { x.ProductId, x.CategoryId });
            builder.Property(e => e.ProductId).HasDefaultValueSql("(newid())");
            builder.Property(e => e.CategoryId).HasDefaultValueSql("(newid())");
            
            builder.HasOne(c => c.Category).WithMany(pc => pc.ProductInCategories).HasForeignKey(c => c.CategoryId);
            builder.HasOne(p => p.Product).WithMany(pc => pc.ProductInCategories).HasForeignKey(p => p.ProductId);
             
              

        }
    }
}