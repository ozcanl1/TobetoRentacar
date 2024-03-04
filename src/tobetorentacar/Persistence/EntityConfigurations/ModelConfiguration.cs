using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Persistence.EntityConfigurations
{
    public class ModelConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasKey(i => i.Id);//PK değeri->Id
            builder.ToTable("Models");//Model entity'sinin hangi tabloyla eşleşeceğini belirt

            //ekstra ilişki kısmı 
            // Brand ile olan ilişki
            builder.HasOne(m => m.Brand)//bir Model yalnızca bir markaya(brand) ait 
                   .WithMany() //bir marka birden çok Modele sahip olabilir
                   .HasForeignKey(m => m.BrandId);//FK değeri->BrandId

            // Fuel ile olan ilişki
            builder.HasOne(m => m.Fuel)//bir Model yalnızca bir yakıt(fuel) ait 
                   .WithMany()//bir yakıt birden çok Modele sahip olabilir
                   .HasForeignKey(m => m.FuelId);//FK

            // Transmission ile olan ilişki
            builder.HasOne(m => m.Transmission)//bir Modell yalnızca bir vites(transmission) ait 
                   .WithMany()//bir vites birden çok Modele sahip olabilir
                   .HasForeignKey(m => m.TransmissionId);//FK
        }
    }
}