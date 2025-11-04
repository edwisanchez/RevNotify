using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RevNotify.Shared.Entites
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public int DocumentId { get; set; }

        [Required ]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage ="El campo {0} es Requerido")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Address { get; set; } = string.Empty;
        public int Age { get; set; }
        public string City { get; set; } = null!;

        [Required]
        [MaxLength(12, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Telephone { get; set; } = null!;

        [Required]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Email { get; set; } = null!;

        public bool AcceptNotifications { get; set; } 
        public bool AcceptDataProcessing { get; set; } 
    }
}