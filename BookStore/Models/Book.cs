using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string? Description { get; set; }

        [Required]
        public int Stock { get; set; }
        
        // Yeni alan
        [StringLength(50)]
        public string? Type { get; set; }  // Kitap türü
        public int? SellerId { get; set; } // Yeni eklenen kolon

        public Seller Seller { get; set; } // Seller ile ilişki
    }
}
