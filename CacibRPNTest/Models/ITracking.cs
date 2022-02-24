using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacibRPNTest.Models
{
    /// <summary>
    /// Tracking info of Each entity
    /// </summary>
    public interface ITracking
    {
        /// <summary>
        /// Keep stack activ or not
        /// </summary>
        bool IsActiv { get; set; }

        /// <summary>
        /// Date of creation
        /// </summary>
        DateTime CreationDate { get; set; }

        /// <summary>
        /// Date of modification
        /// </summary>
        DateTime ModificationDate { get; set; }

        /// <summary>
        /// User who create the stack
        /// </summary>
        string CreatedBy { get; set; }

        /// <summary>
        /// The last modifier
        /// </summary>
        string ModifiedBy { get; set; }
    }
}
