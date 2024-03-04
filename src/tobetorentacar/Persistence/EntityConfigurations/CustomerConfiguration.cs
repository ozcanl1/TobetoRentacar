using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(i => i.Id);//PK->Id
        builder.ToTable("Customers");//Hangi veritabanı tablosuyla eşleşeceğini belirt

        // Customer - CorporateCustomer ilişkisini belirt//
        builder.HasOne(c => c.CorporateCustomers)//
               .WithOne(c => c.Customer)//
               .HasForeignKey<Customer>(c => c.CustomerId); // Customer'ın bağımlı taraf olduğunu belirt//
    }
}