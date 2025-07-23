using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Concept
    {

        public int IdBeer { get; }

        public int Quantity { get; }
        
        public decimal UnitPrice { get; }

        public decimal SubTotal { get; }

        public Concept(int quantity, int idbeer, decimal unitPrice)
        {
            Quantity = quantity;
            IdBeer = idbeer;
            UnitPrice = unitPrice;
            SubTotal = GetTotalPrice();
        }

        private decimal GetTotalPrice() 
        {
            return Quantity * UnitPrice;
        }
    }
}
