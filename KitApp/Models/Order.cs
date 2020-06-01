using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KitApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderDetail> OrderLines { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(100)]
        public string AddressLine1 { get; set; }
        [MaxLength(100)]
        public string AddressLine2 { get; set; }
        [Required]
        [MaxLength(10)]
        [MinLength(4)]
        public string ZipCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(50)]
        public string State { get; set; }
        [Required]
        [MaxLength(50)]
        public string Country { get; set; }
        [Required]
        [MaxLength(50)]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
    }
}
