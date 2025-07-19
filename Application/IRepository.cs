using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness
{
    public interface IRepository<T>
    {
        public Task<T> GetByIdAsync(int id);

        public Task<IEnumerable<T>> GetAllAsync();

        public Task AddAsync(T item);

        public Task EditAsync(T item);

        public Task DeleteAsync(int id);
    }
}
