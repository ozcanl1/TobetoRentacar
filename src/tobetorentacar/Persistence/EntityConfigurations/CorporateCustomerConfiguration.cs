using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Persistence.EntityConfigurations
{
    public class CorporateCustomerConfiguration : IEntityTypeConfiguration<CorporateCustomer>
    {
        public void Configure(EntityTypeBuilder<CorporateCustomer> builder)
        {
            builder.HasKey(i => i.Id);//PK->Id
            builder.ToTable("CorporateCustomers");//CorporateCustomer entity'sinin hangi tabloyla eşleşeceğini belirt

            // CorporateCustomer - Customer ilişkisini belirt
            builder.HasOne(c => c.Customer)//bir BireyselMüşteri yalnızca bir müşteri(customer) aittir 
                   .WithOne(c => c.CorporateCustomers)//bir müşteri(Customer) yalnızca bir BireyselMüşteri aittir 
                   .HasForeignKey<CorporateCustomer>(c => c.CustomerId);//FK->CustomerId,CorporateCustomer'ın bağımlı taraf olduğunu belirt
        }
    }
}