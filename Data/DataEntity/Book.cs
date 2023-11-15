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
        public string? Price { get; set; }
        public int Quantity { get; set; }
        public byte BookCover { get; set; }

        /// <summary>
        /// Navigation property pour la relation one to many avec Author
        /// </summary>
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        /// <summary>
        /// Navigation property pour la relation Many-to-Many
        /// </summary>
        public virtual ICollection<Category> Categories { get; set; }

        public Book()
        {
            Categories = new List<Category>();
        }

    }
}