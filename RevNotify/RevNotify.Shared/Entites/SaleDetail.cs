using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevNotify.Shared.Entites
{
    public class SaleDetail
    {
        public int Id { get; set; }
        public int IdSale { get; set; }
        public int IdProduct { get; set; }
        public decimal Price { get; set; }

        public Sale Sale { get; set; }

    }

}