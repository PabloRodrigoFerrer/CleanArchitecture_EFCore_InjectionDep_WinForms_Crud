using Entity;

namespace ApplicationBusiness
{
    public class AddBrand
    {
        private readonly IRepository<Brand> _repository;

        public AddBrand(IRepository<Brand> repository) 
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(Brand brand)
        {
            if (string.IsNullOrEmpty(brand.Name)) 
                MessageBox.Show("El nombre esta incompleto");
            else 
                await _repository.AddAsync(brand);

        }
    }

    
}
