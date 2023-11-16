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
        /// <summary>
        /// Identifiant de la catégorie
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Nom de la catégorie
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Relation many-to-many 
        /// </summary>
        public virtual ICollection<BookCategory> BookCategories { get; set; }
    }
}
