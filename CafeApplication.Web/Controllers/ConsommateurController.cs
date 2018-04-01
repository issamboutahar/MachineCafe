using CafeApplication.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace CafeApplication.Controllers
{
    [Route("api/[controller]")]
    public class ConsommateurController : Controller
    {

        /// <summary>
        /// Variables de travail
        /// </summary>
        private IService _serv;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="serv"></param>
        public ConsommateurController(IService serv)
        {
            
            _serv = serv;

        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            //return _repoConsommateur.GetAll();
            return Ok(_serv.ObtenirConsommateurAll());

        }


        

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //return _repoConsommateur.Get(id);
            return Ok(_serv.ObtenirConsommateur(id));
        }

        

        

        
    }
}
