﻿using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;
using System;

namespace Persistence.Repositories
{
    public class FuelRepository : EfRepositoryBase<Fuel, Guid, BaseDbContext>, IFuelRepository
    {
        public FuelRepository(BaseDbContext context)
            : base(context)
        {
        }
    }
}
//deneme github
