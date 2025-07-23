using ApplicationBusiness;
using ApplicationBusiness.DTOs;
using Data;
using Entity;
using Microsoft.EntityFrameworkCore;
using Models;
using Repository.AdditionalDataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BeerRepository : IRepositoryAdditionalData<Beer, BeerAdditionalData>
    {

        private readonly AppDbContext _DbContext;

        public BeerRepository(AppDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public async Task AddAsync(Beer item, BeerAdditionalData beerAdditionalData)
        {
            var beerModel = new BeersModel
            {
                Name = item.Name,
                IdBrand = item.BrandId,
                Alcohol = item.Alcohol,
                Description = beerAdditionalData.Description,
                Precio = item.Precio
            };

            await _DbContext.AddAsync(beerModel);
            await _DbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var beerModel = await _DbContext.Beers.FindAsync(id);

            if (beerModel != null)
            {
                _DbContext.Beers.Remove(beerModel);
                await _DbContext.SaveChangesAsync();
            }
        }

        public async Task EditAsync(Beer item, BeerAdditionalData beerAdditionalData)
        {
            var beerModel = await _DbContext.Beers.FindAsync(item.Id);

            beerModel.Name = item.Name;
            beerModel.IdBrand = item.BrandId;
            beerModel.Alcohol = item.Alcohol;
            beerModel.Description = beerAdditionalData.Description;
            beerModel.Precio = item.Precio;

            _DbContext.Entry(beerModel).State = EntityState.Modified;

            await _DbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Beer>> GetAllAsync()
        {
            return await _DbContext.Beers.Select(b => new Beer
            {
                Id = b.Id,
                Name = b.Name,
                BrandId = b.IdBrand,
                Alcohol = b.Alcohol,
                Precio = b.Precio,
            }).ToListAsync();
        }

        public async Task<(Beer, BeerAdditionalData)> GetByIdAsync(int id)
        {
            var beerModel = await _DbContext.Beers.FindAsync(id);
            
            var beer =  new Beer
            {
                Id = beerModel.Id,
                Name = beerModel.Name,
                BrandId = beerModel.IdBrand,
                Alcohol = beerModel.Alcohol,
                Precio = beerModel.Precio,
            };

            var beerADT = new BeerAdditionalData
            {
                Description = beerModel.Description,
            };

            return (beer, beerADT);
        }

        
    }   
}
