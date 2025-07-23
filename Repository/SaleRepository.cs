using ApplicationBusiness;
using Data;
using Entity;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SaleRepository : IRepositorySimple<Sale>
    {
        private readonly AppDbContext _appDbContext;

        public SaleRepository(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }


        public async Task AddAsync(Sale item)
        {
            var saleModel = new SalesModel
            {
                CreationDate = item.Date,
                Total = item.Total,
                Concepts = item.Concepts.Select(x => new ConceptsModel
                {
                    UnitPrice = x.UnitPrice,
                    IdBeer = x.IdBeer,
                    Quantity = x.Quantity,

                }).ToList()
            };


            await _appDbContext.AddAsync(saleModel);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
