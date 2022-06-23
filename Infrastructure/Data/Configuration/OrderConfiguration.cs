using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Infrastructure.Data.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(p => p.Amount)
                .HasPrecision(10, 3)
                .IsRequired();
            
            builder.Property(p => p.Price)
                .HasPrecision(10, 3)
                .IsRequired();
            
            builder.Property(p => p.Product)
                .IsRequired()
                .HasMaxLength(150);
            
            builder.Property(p => p.OrderDate)
                .HasDefaultValueSql("GetDate()");
        }
    }
}
