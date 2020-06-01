using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KitApp.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
        public string PublicationDate { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string PageNumber { get; set; }
        [Required]
        public string Language { get; set; }
        public string Dimensions { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string ImageThumbnailUrl { get; set; }
        [Required]
        public int InStock { get; set; }
        public bool IsPreferredBook { get; set; }
        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
