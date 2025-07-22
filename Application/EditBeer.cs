using ApplicationBusiness.DTOs;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness
{
    public class EditBeer<TAdditionalData>
    {
        private readonly IRepositoryAdditionalData<Beer, TAdditionalData> _repository;
        private readonly IMapper<BeerDTO, Beer> _mapperEntity;
        private readonly IMapper<BeerDTO, TAdditionalData> _mapperAditionalData;
        public EditBeer(IRepositoryAdditionalData<Beer, TAdditionalData> repository, IMapper<BeerDTO, Beer> mapperEntity, IMapper<BeerDTO, TAdditionalData> mapperAditionalData ) 
        {
            _repository = repository;
            _mapperAditionalData = mapperAditionalData;
            _mapperEntity = mapperEntity;
        }

        public async Task ExecuteAsync(BeerDTO beerDTO) 
        {
            var beer = _mapperEntity.Map(beerDTO);
            var additionalData = _mapperAditionalData.Map(beerDTO); 

            if (string.IsNullOrEmpty(beer.Name))
                throw new Exception("El nombre de la cerveza no puede estar vacío.");
            else if ((await _repository.GetByIdAsync(beer.Id)).Item1 == null)
                throw new Exception("La cerveza no existe.");
            else
                await _repository.EditAsync(beer, additionalData);
        }

    }
}
