using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevNotify.Shared.Entites
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public bool RequireMaintenance { get; set; }
        public int DayMaintenance { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}