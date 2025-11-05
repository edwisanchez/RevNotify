using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevNotify.Shared.Entites
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string ProductName { get; set; } = string.Empty;

        public decimal Price { get; set; }

        [Required]
        [MaxLength(7, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Plate { get; set; } = string.Empty;

        public String Model { get; set; } = string.Empty;
        public ProductCategory Category { get; set; }
        public int CategoryId { get; set; }
    }
}