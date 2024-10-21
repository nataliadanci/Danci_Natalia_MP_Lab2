using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Danci_Natalia_MP_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public string Title { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Publishing Date")]
        public DateTime PublishingDate { get; set; }

        [Display(Name = "Publisher")]
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }

        [Display(Name = "Author")]
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }  
    }
}
