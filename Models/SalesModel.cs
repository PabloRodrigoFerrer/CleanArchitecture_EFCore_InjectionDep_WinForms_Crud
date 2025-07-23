using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SalesModel
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }

        public decimal Total {  get; set; }

        public List<ConceptsModel> Concepts { get; set; }

    }
}
