using ApplicationBusiness.DTOs;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness.Mappers
{
    public class MapperToSaleEntity : IMapper<SaleDTO, Sale>
    {
        public Sale Map(SaleDTO saleDTO) 
        {
            var concepts = new List<Concept>();

            foreach (var itemDTO in saleDTO.Concepts) 
            {
                concepts.Add(new Concept(itemDTO.Quantity, itemDTO.IdBeer, itemDTO.UnitPrice));
            }

            return new Sale(DateTime.Now, concepts);
            
        }
    }
}
