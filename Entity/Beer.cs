using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int BrandId { get; set; }

        public decimal Alcohol { get; set; }

        public decimal Precio { get; set; }
        public bool IsStrongBeer() => Alcohol >= 7.5m;
    }
}
