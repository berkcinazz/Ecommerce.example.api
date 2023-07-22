using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable("Brands").HasKey(b => b.Id);

        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.Name).HasColumnName("Name");
        builder.Property(b => b.Email).HasColumnName("Email");
        builder.Property(b => b.PhoneNumber).HasColumnName("PhoneNumber");
        builder.Property(b => b.Website).HasColumnName("Website");
        builder.Property(b => b.Country).HasColumnName("Country");
        builder.Property(b => b.AvatarFilePath).HasColumnName("AvatarFilePath");
        builder.Property(b => b.Approved).HasColumnName("Approved");
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}