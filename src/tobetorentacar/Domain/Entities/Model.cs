using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Model : Entity<Guid>
{
    //deneme
    public Guid FuelId { get; set; }
    public Guid BrandId { get; set; }
    public Guid TransmissionId { get; set; }
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    public short ModelYear { get; set; }

    public Brand? Brand { get; set; } = null;
    public Fuel? Fuel { get; set; } = null;
    public Transmission? Transmission { get; set; } = null;
    public ICollection<Car>? Cars { get; set; } = null;
    public Model() { }


    public Model(Guid fuelId, Guid brandId, Guid transmissionId, string name, decimal dailyPrice, Brand? brand, Fuel? fuel, Transmission? transmission, short modelYear)
    {
        FuelId = fuelId;
        BrandId = brandId;
        TransmissionId = transmissionId;
        Name = name;
        DailyPrice = dailyPrice;
        Brand = brand;
        Fuel = fuel;
        Transmission = transmission;
        ModelYear = modelYear;
    }


}
