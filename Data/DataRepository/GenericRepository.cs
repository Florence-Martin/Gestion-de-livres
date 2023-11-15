using DataContextContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataRepositoryContract;

namespace DataRepository
{
    public abstract class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        /// <summary>
        /// Le dBContext
        /// </summary>
        private readonly IBookDBContext _dBContext;

        /// <summary>
        /// Table
        /// </summary>
        private readonly DbSet<Entity> _table;

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="GenericRepository"/>
        /// </summary>
        /// <param name="dBContext"></param>
        public GenericRepository(IBookDBContext dBContext)
        {
            _dBContext = dBContext;
            _table = _dBContext.Set<Entity>();
        }

        /// <summary>
        /// Méthode permet de créer un élément dans la table Entity
        /// </summary>
        /// <param name="element">Nouvel élément à insérer dans la table</param>
        /// <returns></returns>
        public async Task<Entity> CreateElementAsync(Entity element)
        {
            var elementAdded = await _table.AddAsync(element).ConfigureAwait(false);
            await _dBContext.SaveChangesAsync().ConfigureAwait(false);
            return elementAdded.Entity;
        }

        /// <summary>
        /// Méthode permet de supprimer un élément dans la table Entity
        /// </summary>
        /// <param name="element">L'élément à supprimer</param>
        /// <returns></returns>
        public async Task<Entity> DeleteElementAsync(Entity element)
        {
            var elementDeleted = _table.Remove(element);
            await _dBContext.SaveChangesAsync();
            return elementDeleted.Entity;
        }

        /// <summary>
        /// Méthode permet la récupération de la liste des entités
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Entity>> GetAllAsync()
        {
            return await _table.ToListAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Méthode permet de récupérer un élément dans la table par son Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Entity> GetByKeyAsync(object id)
        {
            return await _table.FindAsync(id).ConfigureAwait(false);
        }

        /// <summary>
        /// Méthode permet de mettre à jour un élément dans la table Entity
        /// </summary>
        /// <param name="element">L'élément à modifier</param>
        /// <returns></returns>
        public async Task<Entity> UpdateElementAsync(Entity element)
        {
            var elementUpdated =  _table.Update(element);
            await _dBContext.SaveChangesAsync();
            return elementUpdated.Entity;
        }
    }
}
