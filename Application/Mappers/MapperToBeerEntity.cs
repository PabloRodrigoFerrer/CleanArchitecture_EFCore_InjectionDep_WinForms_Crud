using ApplicationBusiness.DTOs;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness.Mappers
{
    public class MapperToBeerEntity : IMapper<BeerDTO, Beer>
    {
        public Beer Map(BeerDTO input)
        {
            return new Beer()
            {
                Id = input.Id,
                Name = input.Name,
                BrandId = input.IdBrand,
                Alcohol = input.Alcohol,
                Precio = input.Precio
            };
        }
    }
}
