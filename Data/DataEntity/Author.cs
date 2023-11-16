using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataEntity
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorId { get; set; }
        public string? Name { get; set; }
        public string? Nationality { get; set; }

        /// <summary>
        /// Relation one-to-many avec Book
        /// </summary>
        public List<Book> Books { get; set; }
    }
}
