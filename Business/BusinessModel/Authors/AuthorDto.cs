using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel.Author
{
    public class AuthorDto
    {
        ///  ajouter un nouvel auteur
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public List<string> BookTitles { get; set; }

        /// ajouter des titres de livres à la liste de livres
        public AuthorDto()
        {
            BookTitles = new List<string>();
        }
    }
}
