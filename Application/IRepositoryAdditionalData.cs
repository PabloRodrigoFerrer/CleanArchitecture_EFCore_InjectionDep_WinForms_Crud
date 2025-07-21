using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness
{
    public interface IRepositoryAdditionalData<T, TAdditionalData>
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task AddAsync(T entity, TAdditionalData additionalData);

        Task EditAsync(T entity);
        Task DeleteAsync(int id);

    }
}
