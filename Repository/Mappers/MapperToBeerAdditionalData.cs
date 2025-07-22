using ApplicationBusiness;
using ApplicationBusiness.DTOs;
using Repository.AdditionalDataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Mappers
{
    public class MapperToBeerAdditionalData : IMapper<BeerDTO, BeerAdditionalData>
    {
        public BeerAdditionalData Map(BeerDTO input)
        {
            return new BeerAdditionalData
            {
                Description = input.Description
            };
        }
    }
}
