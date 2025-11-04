using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RevNotify.Shared.Entites
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int Age { get; set; }
        public string City { get; set; } = null!;

        [Required]
        public string Telephone { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        public bool AcceptNotifications { get; set; } 
        public bool AcceptDataProcessing { get; set; } 
    }
}