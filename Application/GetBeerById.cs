using ApplicationBusiness.DTOs;
using ApplicationBusiness.Mappers;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness
{
    public class GetBeerById<TAdditionalData>
    {
        private readonly IRepositoryAdditionalData<Beer, TAdditionalData> _beerRepository;
        private readonly ISuperMapper<Beer, TAdditionalData, BeerDTO> _mapperToBeerDTO;

        public GetBeerById(IRepositoryAdditionalData<Beer, TAdditionalData> beerRepository, ISuperMapper<Beer, TAdditionalData, BeerDTO> mapperToBeerDto) 
        { 
            _beerRepository = beerRepository;
            _mapperToBeerDTO = mapperToBeerDto;
        }

        public async Task<BeerDTO> ExecuteAsync(int id) 
        {
            var (beer, beerAdditionalData) = await _beerRepository.GetByIdAsync(id);

            return _mapperToBeerDTO.Map(beer, beerAdditionalData); 
        }


    }
}
