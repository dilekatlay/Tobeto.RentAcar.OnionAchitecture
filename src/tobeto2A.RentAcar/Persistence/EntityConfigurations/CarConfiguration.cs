using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable("Cars").HasKey(c => c.Id);

        builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
        builder.Property(c => c.Id).HasColumnName("Id");
        builder.Property(c => c.ColorId).HasColumnName("ColorId");
        builder.Property(c => c.ModelId).HasColumnName("ModelId");
        builder.Property(c => c.CarState).HasColumnName("CarState");
        builder.Property(c => c.Kilometer).HasColumnName("Kilometer");
        builder.Property(c => c.Plate).HasColumnName("Plate");
        builder.Property(c => c.UpdatedAt).HasColumnName("UpdatedAt");
        builder.Property(c => c.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(c => c.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(c => c.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
    }
}