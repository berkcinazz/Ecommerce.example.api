using Application.Features.OperationClaims.Constants;
using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
{
    public void Configure(EntityTypeBuilder<OperationClaim> builder)
    {
        builder.ToTable("OperationClaims").HasKey(oc => oc.Id);

        builder.Property(oc => oc.Id).HasColumnName("Id").IsRequired();
        builder.Property(oc => oc.Name).HasColumnName("Name").IsRequired();
        builder.Property(oc => oc.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(oc => oc.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(oc => oc.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(oc => !oc.DeletedDate.HasValue);

        builder.HasMany(oc => oc.UserOperationClaims);

        builder.HasData(getSeeds());
    }

    private HashSet<OperationClaim> getSeeds()
    {
        int id = 0;
        HashSet<OperationClaim> seeds =
            new()
            {
                new OperationClaim { Id = ++id, Name = GeneralOperationClaims.Admin }
            };

        
        #region Products
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Products.Admin" });
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Products.Read" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Products.Write" });
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Products.Add" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Products.Update" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Products.Delete" });
        
        #endregion
        
        
        #region Brands
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Brands.Admin" });
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Brands.Read" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Brands.Write" });
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Brands.Add" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Brands.Update" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Brands.Delete" });
        
        #endregion
        
        
        #region Orders
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Orders.Admin" });
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Orders.Read" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Orders.Write" });
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Orders.Add" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Orders.Update" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Orders.Delete" });
        
        #endregion
        
        
        #region Baskets
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Baskets.Admin" });
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Baskets.Read" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Baskets.Write" });
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "Baskets.Add" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Baskets.Update" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "Baskets.Delete" });
        
        #endregion
        
        
        #region OrderItems
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "OrderItems.Admin" });
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "OrderItems.Read" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "OrderItems.Write" });
        
        seeds.Add(new OperationClaim { Id = ++id, Name = "OrderItems.Add" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "OrderItems.Update" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "OrderItems.Delete" });
        
        #endregion
        
        return seeds;
    }
}
