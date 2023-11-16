using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel.Books
{
    public class ReadBookDto : CreateBookDto
    {
        /// <summary>
        /// Identifiant du livre
        /// </summary>
        public int BookId { get; set; }
    }
}
