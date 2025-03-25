using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdPracticeMobile
{
    public class MarketOffers
    {
        public int Id { get; set; }
        public string ComputerName { get; set; }
        public string SellerName { get; set; }  
        public int BatchSize { get; set; }
        public decimal BatchPrice { get; set; }
    }
}
