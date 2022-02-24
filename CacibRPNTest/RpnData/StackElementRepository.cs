using CacibRPNTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CacibRPNTest.RpnData
{
    /// <summary>
    /// Implementation of Stack Elements Repository
    /// </summary>
    public class StackElementRepository : IRepository<StackElement>, IEntities<StackElement>
    {
        /// <summary>
        /// The context of Rpn Data
        /// </summary>
        private IRpnDbContext _rpnDbContext;

        /// <summary>
        /// Ctor
        /// </summary>
        public StackElementRepository(IRpnDbContext rpnDbContext)
        {
            _rpnDbContext = rpnDbContext;
        }


        public List<StackElement> Entities
        {
            get
            {
                return _rpnDbContext.StackElements.ToList();
            }
        }

        public StackElement FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(StackElement entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Insert(StackElement entity)
        {
            throw new NotImplementedException();
        }

        public void Update(StackElement entityToUpdate)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}