using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacibRPNTest.RpnData
{
    /// <summary>
    /// Entities Records
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IEntities<TEntity> where TEntity : class
    {
        /// <summary>
        /// Entities records list
        /// </summary>
        List<TEntity> Entities { get; }
    }
}
