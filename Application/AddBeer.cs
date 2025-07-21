using ApplicationBusiness.DTOs;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness
{
    public class AddBeer<TAdditionalData>
    {
        private readonly IRepositoryAdditionalData<Beer, TAdditionalData> _beerRepository;
        private readonly IMapper<BeerDTO, Beer> _mapperEntity;
        private readonly IMapper<BeerDTO, TAdditionalData> _mapperAditionalData;

        public AddBeer(IRepositoryAdditionalData<Beer, TAdditionalData> repository, IMapper<BeerDTO, Beer> mapperEntity, IMapper<BeerDTO, TAdditionalData> mapperAditionalData) 
        {
            _beerRepository = repository;
            _mapperEntity = mapperEntity;
            _mapperAditionalData = mapperAditionalData;
        }

        public async Task ExecuteAsync(BeerDTO beerDTO)
        {
            var beer = _mapperEntity.Map(beerDTO);
            var additionalData = _mapperAditionalData.Map(beerDTO);


            if (beerDTO.Name == null)
                throw new Exception("El nombre de la cerveza no puede estar vacío.");

            await _beerRepository.AddAsync(beer, additionalData);
        }
    }
}
