using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoPet.Domains;
using ProjetoPet.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjetoPet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPetController : ControllerBase
    {

        //chamando repository
        TipoPetRepository repo = new TipoPetRepository();


        // GET: api/<TipoPetController>
        [HttpGet]
        public List<TipoPet> Get()
        {
            return repo.LerTodos();
        }

        // GET api/<TipoPetController>/5
        [HttpGet("{id}")]
        public TipoPet Get(int id)
        {
            return repo.BuscarPorId(id);
        }

        // POST api/<TipoPetController>
        [HttpPost]
        public void Post([FromBody] TipoPet p)
        {
            repo.Cadastrar(p);
        }

        // PUT api/<TipoPetController>/5
        [HttpPut("{id}")]
        public TipoPet Put(int id, [FromBody] TipoPet p)
        {
            return repo.Alterar(p);
        }

        // DELETE api/<TipoPetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repo.Excluir(id);
        }
    }
}
