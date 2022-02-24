using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacibRPNTest.Models
{
    /// <summary>
    /// Stack element source info
    /// </summary>
    public interface IStackElementSource
    {
        /// <summary>
        /// Determine whether the element number as been pushed
        /// </summary>
        bool IsFromPush { get; set; }

        /// <summary>
        /// as been produce by an operationas been pushed
        /// </summary>
        bool IsFromOperation { get; set; }
    }
}
