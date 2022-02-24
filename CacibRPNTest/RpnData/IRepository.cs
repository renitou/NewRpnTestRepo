using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacibRPNTest.RpnData
{
    /// <summary>
    /// Repository 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// 
    public interface IRepository<TEntity> where TEntity : class
    {

        /// <summary>
        /// Retrieve a single entity using it's primary key, null if not found.
        /// </summary>
        /// <param name="id">The primary key of the record</param>
        /// <returns>T</returns>
        TEntity FindById(int id);

        /// <summary>
        /// Delete an entity by primary key.
        /// </summary>
        /// <param name="id">The primary key of the record</param>
        void Delete(int id);

        /// <summary>
        /// Deletes this entity from the database.
        /// </summary>
        /// <param name="entityToDelete">The entity to delete</param>
        void Delete(TEntity entityToDelete);

        /// <summary>
        /// Inserts this entity into the database.
        /// </summary>
        /// <param name="entity">The entity to insert</param>
        /// <returns>The inserted entity</returns>
        void Insert(TEntity entity);

        /// <summary>
        /// Updates this entity in the database.
        /// </summary>
        /// <param name="entityToUpdate">The entity to update</param>
        void Update(TEntity entityToUpdate);

        /// <summary>
        /// Commit change to the database
        /// </summary>
        void Save();
    }
}
