using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness
{
    public class EditBeer
    {
        private readonly IRepository<Beer> _repository;

        public EditBeer(IRepository<Beer> repository) 
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(Beer beer) 
        {
            if (string.IsNullOrEmpty(beer.Name))
                throw new Exception("El nombre de la cerveza no puede estar vacío.");
            else if (await _repository.GetByIdAsync(beer.Id) == null)
                throw new Exception("La cerveza no existe.");
            else
                await _repository.EditAsync(beer);
        }

    }
}
