﻿using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Domain.Data.Configration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name)
                .HasMaxLength(256)
                .IsRequired();
            builder.Property(e => e.Description)
                .HasMaxLength(256)
                .IsRequired();

           
        }
    }
}
