using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacibRPNTest.Models
{
    /// <summary>
    /// stack
    /// </summary>
    public class Stack: ITracking
    {
        /// <summary>
        /// Element Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Keep stack activ or not
        /// </summary>
        public bool IsActiv { get; set; }

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
        /// List of umbers owned by this stack
        /// </summary>
        List<StackElement> StackElements { get; set; }
    }
}
