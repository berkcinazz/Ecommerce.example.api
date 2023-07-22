using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products").HasKey(p => p.Id);

        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Name).HasColumnName("Name");
        builder.Property(p => p.Description).HasColumnName("Description");
        builder.Property(p => p.ProductCode).HasColumnName("ProductCode");
        builder.Property(p => p.UnitPrice).HasColumnName("UnitPrice");
        builder.Property(p => p.UnitsInStock).HasColumnName("UnitsInStock");
        builder.Property(p => p.QuantityPerUnit).HasColumnName("QuantityPerUnit");
        builder.Property(p => p.CommonCode).HasColumnName("CommonCode");
        builder.Property(p => p.OnSale).HasColumnName("OnSale");
        builder.Property(p => p.ShippingCost).HasColumnName("ShippingCost");
        builder.Property(p => p.BrandId).HasColumnName("BrandId");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
    }
}