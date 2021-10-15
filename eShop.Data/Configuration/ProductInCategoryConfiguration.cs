using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShop.Data.Configuration
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(t=> new { t.CategoryId, t.ProductId });
            builder.ToTable("ProductInCategories");
            builder.HasOne(t => t.Product).WithMany(p => p.ProductInCategories)
                .HasForeignKey(p => p.ProductId);
            builder.HasOne(t => t.Category).WithMany(p => p.ProductInCategories)
                .HasForeignKey(p => p.CategoryId);
        }
}
}
