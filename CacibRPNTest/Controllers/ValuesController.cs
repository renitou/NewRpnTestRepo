using CacibRPNTest.RpnBusiness;
using CacibRPNTest.RpnData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CacibRPNTest.Controllers
{
    public class ValuesController : ApiController
    {
        IOperation _operations;
        IRepository<CacibRPNTest.Models.Stack> _stackRepository;
        IRepository<CacibRPNTest.Models.StackElement> _stackElementRepository;

        public ValuesController(IOperation operations, 
            IRepository<CacibRPNTest.Models.Stack> stackRepository, 
            IRepository<CacibRPNTest.Models.StackElement> stackElementRepository)
        {
            _operations = operations;
            _stackRepository = stackRepository;
            _stackElementRepository = stackElementRepository;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}