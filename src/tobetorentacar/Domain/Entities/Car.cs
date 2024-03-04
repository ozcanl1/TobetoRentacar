using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Car : Entity<Guid>
{
    public string Name { get; set; }
    public Guid ColorId { get; set; }
    public Guid ModelId { get; set; }
    public string CarState { get; set; }
    public int Kilometer { get; set; }
    public string Plate { get; set; }
    public bool IsDeleted { get; set; }
    public string Model { get; set; }
    public Car()
    {
    }
    public Car(string name, Guid colorId, Guid modelId, string carState, int kilometer, string plate, bool ısDeleted, string model)
    {
        Name = name;
        ColorId = colorId;
        ModelId = modelId;
        CarState = carState;
        Kilometer = kilometer;
        Plate = plate;
        IsDeleted = ısDeleted;
        Model = model;
    }
}
