using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Domain.Data.Configration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
           builder.ToTable("Category");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.Description)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasMany(o=>o.Products)
                .WithOne(o=>o.Category)
                .HasForeignKey(o=>o.CategoryId)
                .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}
