using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Seller
    {
        public int SellerId { get; set; }

        [Required]
        [StringLength(100)]
        public string? SellerName { get; set; }

        // Diğer seller özellikleri burada olabilir

        // İlişkili kitaplar
        public ICollection<Book> Books { get; set; }
    }
}
