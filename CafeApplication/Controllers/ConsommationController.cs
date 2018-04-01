using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CafeApplication.Data;
using CafeApplication.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace CafeApplication.Controllers
{
    [Route("api/[controller]")]
    public class ConsommationController : Controller
    {
        private IRepository<Consommation> _repoConsommation;
        

        public ConsommationController(IRepository<Consommation> repoConsommation)
        {
            _repoConsommation = repoConsommation;

        }


        // GET api/values
        [HttpGet]
        public IEnumerable<Consommation> Get()
        {
            return _repoConsommation.GetAll();

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Consommation Get(long id)
        {
            return _repoConsommation.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Consommation cons)
        {
            _repoConsommation.Insert(cons);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(long id, [FromBody]Consommation cons)
        {
            _repoConsommation.Update(cons);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete([FromBody]Consommation cons)
        {
            _repoConsommation.Delete(cons);
        }
    }
}
