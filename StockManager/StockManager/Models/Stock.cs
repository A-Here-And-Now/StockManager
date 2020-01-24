using System;
using System.Collections.Generic;
using System.Text;

namespace StockManager.Domain.Models
{
    public class Stock
    {
        public string Symbol { get; set; }
        public double PricePerShare { get; set; }
    }
}
