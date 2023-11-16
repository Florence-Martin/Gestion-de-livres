using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        public string? Name { get; set; }

        /// <summary>
        /// Relation many-to-many 
        /// </summary>
        public virtual ICollection<BookCategory> BookCategories { get; set; }
    }
}
