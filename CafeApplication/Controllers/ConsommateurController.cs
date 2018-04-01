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
    public class ConsommateurController : Controller
    {
        private IRepository<Consommateur> _repoConsommateur;
        

        public ConsommateurController(IRepository<Consommateur> repoConsommateur)
        {
            _repoConsommateur = repoConsommateur;

        }


        // GET api/values
        [HttpGet]
        public IEnumerable<Consommateur> Get()
        {
            return _repoConsommateur.GetAll();
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Consommateur Get(long id)
        {
            return _repoConsommateur.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Consommateur cons)
        {
            _repoConsommateur.Insert(cons);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(long id, [FromBody]Consommateur cons)
        {
            _repoConsommateur.Update(cons);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete([FromBody]Consommateur cons)
        {
            _repoConsommateur.Delete(cons);
        }
    }
}
