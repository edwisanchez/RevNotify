using System.ComponentModel.DataAnnotations;

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
    }
}