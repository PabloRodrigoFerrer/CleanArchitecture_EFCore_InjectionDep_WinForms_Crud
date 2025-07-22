using Data;
using Microsoft.EntityFrameworkCore;
using Repository.QueryResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.QueryObjects
{
    public class BeerWithBrandAndQuery
    {
        private readonly AppDbContext _dbContext;

        public BeerWithBrandAndQuery(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<BeerWithBrandResult>> GetAllAsync()
            => await _dbContext.Beers.Join(
                _dbContext.Brands,
                Beers => Beers.IdBrand,
                Brands => Brands.Id,
                (beers, Brands) => new BeerWithBrandResult
                {
                    Id = beers.Id,
                    Name = beers.Name,
                    BrandName = Brands.Name,
                }).ToListAsync();
    }
}
