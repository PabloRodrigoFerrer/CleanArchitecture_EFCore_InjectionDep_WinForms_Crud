﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness.DTOs
{
    public class BeerDTO
    {     
        
        public int Id { get; set; }
        public string Name { get; set; }

        public int IdBrand { get; set; }

        public decimal Alcohol { get; set; }

        public string? Description { get; set; }


    }
}
