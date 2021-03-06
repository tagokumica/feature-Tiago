using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mapping
{
    public class PhoneMapping : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.HasKey(s => s.PhoneID);


            builder.HasOne(s => s.Customer)
                .WithMany(s => s.Phone)
                .HasForeignKey(s => s.PhoneID);


        

            builder.Property(s => s.Number)
                .IsRequired()
                .HasColumnType("int");



            builder.Property(s => s.TypePhone)
                .IsRequired()
                .HasColumnType("int");



            builder.ToTable("Phone");
        }
    }

}