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
    public class RacaController : ControllerBase
    {

        //chamando repository
        RacaRepository repo = new RacaRepository();

        // GET: api/<RacaController>
        [HttpGet]
        public List<Raca> Get()
        {
            return repo.LerTodos();
        }

        // GET api/<RacaController>/5
        [HttpGet("{id}")]
        public Raca Get(int id)
        {
            return repo.BuscarPorId(id);
        }

        // POST api/<RacaController>
        [HttpPost]
        public void Post([FromBody] Raca r)
        {
            repo.Cadastrar(r);
        }

        // PUT api/<RacaController>/5
        [HttpPut("{id}")]
        public Raca Put(int id, [FromBody] Raca r)
        {
            return repo.Alterar(r);
        }

        // DELETE api/<RacaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repo.Excluir(id);
        }
    }
}
