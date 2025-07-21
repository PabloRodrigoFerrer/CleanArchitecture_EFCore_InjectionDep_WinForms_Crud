using ApplicationBusiness;
using Data;
using Models;
using Microsoft.EntityFrameworkCore;
using Entity;

namespace Repository
{
    public class BrandRepository : IRepository<Brand>
    {
        private readonly AppDbContext _dbContext;

        public BrandRepository(AppDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public async Task AddAsync(Brand brand)
        {
            var brandModel = new BrandModel()
            {   
                Name = brand.Name
            };

            await _dbContext.AddAsync(brandModel);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var model = await _dbContext.Brands.FindAsync(id);
            _dbContext.Brands.Remove(model);
            _dbContext.SaveChanges();
        }

        public async Task EditAsync(Brand item)
        {
            var model = await _dbContext.Brands.FindAsync(item.Id);

            model.Name = item.Name;

            _dbContext.Entry(model).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public async Task<IEnumerable<Brand>> GetAllAsync()
         => await _dbContext.Brands.Select(b => new Brand
            {
                Id = b.Id,
                Name = b.Name
            }).ToListAsync();

        public async Task<Brand> GetByIdAsync(int id)
        {
            var brand = await _dbContext.Brands.FindAsync(id);

            return new Brand
            {
                Id = brand.Id,
                Name = brand.Name
            };
        }
    }
}
