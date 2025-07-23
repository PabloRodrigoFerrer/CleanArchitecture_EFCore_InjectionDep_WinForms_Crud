using ApplicationBusiness.DTOs;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness
{
    public class CreateSale
    {
        private readonly IRepositorySimple<Sale> _repository;
        private readonly IMapper<SaleDTO, Sale> _mapper;

        public CreateSale(IRepositorySimple<Sale> repository, IMapper<SaleDTO, Sale> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task ExecuteAsync(SaleDTO saleDTO) 
        {
            var sale = _mapper.Map(saleDTO);

            if (sale.Concepts.Count == 0)
            {
                throw new Exception("Una venta debe tener conceptos");
            }

            if (sale.Total <= 0)
            {
                throw new Exception("Una venta debe tener más de $0.00 en total");
            }

            await _repository.AddAsync(sale);
        }
    }
}
