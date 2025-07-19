using ApplicationBusiness;
using Data;
using DTOs;
using Microsoft.EntityFrameworkCore;
using Models.Entidades;

namespace Repository
{
    public class BrandRepository : IRepository<BrandDto>
    {
        private readonly AppDbContext _dbContext;

        public BrandRepository(AppDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public async Task AddAsync(BrandDto brandDto)
        {
            var brand = new Brand()
            {   

                Name = brandDto.Name
            };

            await _dbContext.Brands.AddAsync(brand);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var model = await _dbContext.Brands.FindAsync(id);
            _dbContext.Brands.Remove(model);
            _dbContext.SaveChanges();
        }

        public async Task EditAsync(BrandDto item)
        {
            var model = await _dbContext.Brands.FindAsync(item.Id);

            model.Name = item.Name;

            _dbContext.Entry(model).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
        

        public async Task<IEnumerable<BrandDto>> GetAllAsync()
         => await _dbContext.Brands.Select(b => new BrandDto
            {
                Id = b.Id,
                Name = b.Name
            }).ToListAsync();

        public async Task<BrandDto> GetByIdAsync(int id)
        {
            var brand = await _dbContext.Brands.FindAsync(id);

            return new BrandDto
            {
                Id = brand.Id,
                Name = brand.Name
            };
        }
    }
}
