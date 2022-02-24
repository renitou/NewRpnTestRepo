using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacibRPNTest.RpnBusiness
{
    /// <summary>
    /// Push Operation
    /// </summary>
    public interface IOperation
    {
        /// <summary>
        /// Addition
        /// </summary>
        /// <param name="x">number 1</param>
        /// <param name="y">number 2</param>
        /// <returns></returns>
        long Addition(long x, long y);

        /// <summary>
        /// Substraction
        /// </summary>
        /// <param name="x">number on wich substract</param>
        /// <param name="y">number to substract</param>
        /// <returns></returns>
        long subtraction(long x, long y);

        /// <summary>
        /// Multiplication
        /// </summary>
        /// <param name="x">number</param>
        /// <param name="y">number</param>
        /// <returns></returns>
        long Multiplication(long x, long y);

        /// <summary>
        /// Division operation
        /// </summary>
        /// <param name="x">number to be divided</param>
        /// <param name="y">numer of the division</param>
        /// <returns></returns>
        long Division(long x, long y);
    }
}
