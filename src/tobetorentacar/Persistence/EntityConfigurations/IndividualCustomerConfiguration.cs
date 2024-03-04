using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class IndividualCustomerConfiguration : IEntityTypeConfiguration<IndividualCustomer>
{
    public void Configure(EntityTypeBuilder<IndividualCustomer> builder)
    {
        builder.HasKey(i => i.Id);//PK->Id
        builder.ToTable("IndividualCustomers");//Hangi veritabanı tablosuyla eşleşeceğini belirt

        //InvidualCustomer - Customer ilişkisini belirt
        builder.HasOne(c => c.Customer)//bir KurumsalMüşteri yalnızca bir müşteri(customer) aittir 
               .WithOne(c => c.IndividualCustomers)//bir müşteri(Customer) yalnızca bir KurumsalMüşteri aittir 
               .HasForeignKey<IndividualCustomer>(c => c.CustomerId); //FK->CustomerId InvidualCustomer'ın bağımlı taraf olduğunu belirt
    }
}