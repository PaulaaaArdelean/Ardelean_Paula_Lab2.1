using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using System.Xml.Linq;

namespace Ardelean_Paula_Lab2.Models
{

    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]


       
        [StringLength(150, MinimumLength = 3)]
        [Required (ErrorMessage ="Titlul trebuie sa fie completat obligatoriu")]
        public string Title { get; set; }
        //public string Author { get; set; }

       
        public int? AuthorID { get; set; }  //cheie straina
        public Author? Author { get; set; } //navigation property

       
        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
      
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }

    }
}
