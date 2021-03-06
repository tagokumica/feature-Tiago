using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mapping
{
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(s => s.CustomerID);




            builder.Property(s => s.Name)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(s => s.Email)
                .IsRequired()
                .HasColumnType("varchar(50)");





            builder.ToTable("Customer");
        }
    }
}