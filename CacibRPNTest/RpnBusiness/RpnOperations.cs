using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CacibRPNTest.RpnBusiness
{
    public class RpnOperations: IOperation
    {
        public RpnOperations ()
	    {

	    }
        public long Addition(long x, long y)
        {
            return x + y;
        }

        public long subtraction(long x, long y)
        {
            return x - y;
        }

        public long Multiplication(long x, long y)
        {
            return x * y;
        }

        public long Division(long x, long y)
        {
            return x / y;
        }
    }
}