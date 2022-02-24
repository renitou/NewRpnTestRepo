using CacibRPNTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CacibRPNTest.RpnData
{
    public class RpnDbContext : DbContext, IRpnDbContext
    {
        public DbSet<Stack> Stacks { get; set; }
        public DbSet<StackElement> StackElements { get; set; }

        public RpnDbContext (string connectionString)
	    {

	    }

        /// <summary>
        /// Mapping object relational model to the table
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// Close connection
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            this.Dispose();
            base.Dispose(disposing);
        }
    }
}