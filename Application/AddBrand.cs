using DTOs;


namespace ApplicationBusiness
{
    public class AddBrand
    {
        private readonly IRepository<BrandDto> _repository;

        public AddBrand(IRepository<BrandDto> repository) 
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(BrandDto brand)
        {
            if (string.IsNullOrEmpty(brand.Name)) 
                MessageBox.Show("El nombre esta incompleto");
            else 
                await _repository.AddAsync(brand);

        }
    }

    
}
