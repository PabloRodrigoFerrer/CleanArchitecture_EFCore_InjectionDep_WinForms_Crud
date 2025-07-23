using ApplicationBusiness;
using ApplicationBusiness.DTOs;
using Entity;
using Repository.AdditionalDataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Mappers
{
    public class MapperToBeerDto : ISuperMapper<Beer, BeerAdditionalData, BeerDTO>
    {
        public BeerDTO Map(Beer beer, BeerAdditionalData beerAdditionalData)
        {
            return new BeerDTO
            {
                Id = beer.Id,
                Name = beer.Name,
                IdBrand = beer.BrandId,
                Alcohol = beer.Alcohol,
                Precio = beer.Precio,
                Description = beerAdditionalData.Description,
            };
        }
    }
}
        

