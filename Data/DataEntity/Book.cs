using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }
        public int Quantity { get; set; }
        public byte BookCover { get; set; }
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }

        /// <summary>
        /// Foreign key for one-to-many 
        /// </summary>
        public int AuthorId { get; set; }

        public Author Author { get; set; }


        /// <summary>
        /// Relation many-to-many 
        /// </summary>
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}