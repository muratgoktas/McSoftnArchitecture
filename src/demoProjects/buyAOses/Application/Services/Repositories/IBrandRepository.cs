using Core.Persistence.Repositories;
using Domain.Entities;
using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Repositories;

public interface IBrandRepository : IAsyncRepository<Brand>, IRepository<Brand>
{
    Task<Brand> AddAsync(Brand mappedBrand);
}
