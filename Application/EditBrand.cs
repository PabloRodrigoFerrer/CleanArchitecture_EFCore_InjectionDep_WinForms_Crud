using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness
{
    public class EditBrand
    {
        private readonly IRepository<Brand> _repository;

        public EditBrand(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(Brand brand) 
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
