using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacibRPNTest.Models
{
    /// <summary>
    /// Stack element (number)
    /// </summary>
    public class StackElement : IStackElementSource, ITracking
    {
        /// <summary>
        /// Element Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Element as number
        /// </summary>
        public long number { get; set; }

        /// <summary>
        /// Determine whether the element number as been pushed
        /// </summary>
        public bool IsFromPush { get; set; }

        /// <summary>as been produce by an operationas been pushed
        /// </summary>
        public bool IsFromOperation { get; set; }


        /// <summary>
        /// Date of creation
        /// </summary>
        public DateTime CreationDate { get; set; }


        /// <summary>
        /// Date of modification
        /// </summary>
        public DateTime ModificationDate { get; set; }

        /// <summary>
        /// User who create the stack
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// The last modifier
        /// </summary>
        public string ModifiedBy { get; set; }

        /// <summary>
        /// keep element activ or not
        /// </summary>
        public bool IsActiv { get; set; }
    }
}
