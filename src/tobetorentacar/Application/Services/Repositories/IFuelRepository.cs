using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using System;

namespace Application.Services.Repositories
{
    public interface IFuelRepository : IAsyncRepository<Fuel, Guid>, IRepository<Fuel, Guid>
    {
    }
}
