﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ConceptsModel
    {
        public int Id { get; set; }

        public int IdBeer { get; set; }

        public int IdSale { get; set; }
        
        public decimal UnitPrice {  get; set; }
        
        public int Quantity {  get; set; }

    }
}
