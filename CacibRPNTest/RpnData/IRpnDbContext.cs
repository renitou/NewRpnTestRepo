using CacibRPNTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacibRPNTest.RpnData
{
    public interface IRpnDbContext: IDisposable
    {
        DbSet<Stack> Stacks { get; set; }
        DbSet<StackElement> StackElements { get; set; }
    }
}
