using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepositoryContract
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        /// <summary>
        /// Méthode permet la récupération de la liste des entités
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Entity>> GetAllAsync();

        /// <summary>
        /// Méthode permet de récupérer un élément dans la table par son Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Entity> GetByKeyAsync(object id);

       /// <summary>
       /// Méthode permet de créer un élément dans la table Entity
       /// </summary>
       /// <param name="element">Nouvel élément à insérer dans la table</param>
       /// <returns></returns>
        Task<Entity> CreateElementAsync(Entity element);

        /// <summary>
        /// Méthode permet de mettre à jour un élément dans la table Entity
        /// </summary>
        /// <param name="element">L'élément à modifier</param>
        /// <returns></returns>
        Task<Entity> UpdateElementAsync(Entity element);

        /// <summary>
        /// Méthode permet de supprimer un élément dans la table Entity
        /// </summary>
        /// <param name="element">L'élément à supprimer</param>
        /// <returns></returns>
        Task<Entity> DeleteElementAsync(Entity element);


    }
}
