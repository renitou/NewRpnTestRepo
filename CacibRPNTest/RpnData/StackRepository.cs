using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CacibRPNTest.Models;

namespace CacibRPNTest.RpnData
{
    /// <summary>
    /// Implementation of Stack Repository
    /// </summary>
    public class StackRepository : IRepository<Stack>, IEntities<Stack>
    {
        private IRpnDbContext _rpnDbContext;

        public StackRepository (IRpnDbContext rpnDbContext)
	    {
            _rpnDbContext = rpnDbContext;
	    }

        public List<Stack> Entities 
        {
            get 
            {
                return _rpnDbContext.Stacks.ToList();
            }
        }

        public Stack FindById(int id)
        {
            return null;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Stack entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Insert(Stack entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Stack entityToUpdate)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}