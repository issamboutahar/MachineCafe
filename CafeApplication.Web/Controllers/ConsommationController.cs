using System.Collections.Generic;
using AutoMapper;
using CafeApplication.Service.Factory.Interfaces;
using CafeApplication.Service.Service;
using CafeApplication.Web.Models;
using Microsoft.AspNetCore.Mvc;


namespace CafeApplication.Controllers
{
    [Route("api/[controller]")]
    public class ConsommationController : Controller
    {
        /// <summary>
        /// Variable de travail
        /// </summary>
        private IService _serv;
        private IMapper _mapper;
        
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="serv"></param>
        /// <param name="mapper"></param>
        public ConsommationController(IService serv, IMapper mapper)
        {
            _serv = serv;
            _mapper = mapper;

        }


        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_mapper.Map<IEnumerable<TypeBoissonViewModel>>(_serv.ObtenirConsommationAll()));
            
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            return Ok(_mapper.Map<TypeBoissonViewModel>(_serv.ObtenirDerniereConsommationParClient(id)));

        }



        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]TypeBoissonViewModel cons)
        {
            _serv.AjouterConsommation(_mapper.Map<IBreuvage>( cons), 0);
            
            return Ok(cons);


        }

        
    }
}
