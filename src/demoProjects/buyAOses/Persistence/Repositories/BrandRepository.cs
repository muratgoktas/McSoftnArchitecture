using Core.Persistence.Repositories;
using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class BrandRepository : EfRepositoryBase<Brand, DbContext>
    {
        public BrandRepository(DbContext context) : base(context)
        {
        }
    }
}
