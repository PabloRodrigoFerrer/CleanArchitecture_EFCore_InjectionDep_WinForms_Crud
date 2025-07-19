using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness
{
    public class EditBrand
    {
        private readonly IRepository<BrandDto> _repository;

        public EditBrand(IRepository<BrandDto> repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(BrandDto brand) 
        { 
            if (string.IsNullOrEmpty(brand.Name)) 
                MessageBox.Show("El nombre esta incompleto");
            else if (await _repository.GetByIdAsync(brand.Id) == null)
                MessageBox.Show("La marca no existe");
            else
                await _repository.EditAsync(brand);        
        } 
    }
}
