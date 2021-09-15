using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BancoAPI.Controllers
{
    [Route("fapen/contaInvestimento")]
    [ApiController]
    public class ContaInvestimentoController : ControllerBase
    {

        // GET: api/<ContaInvestimentoController>
        [HttpGet]
        public List<ContaInvestimento> Get()
        {
            ContaInvestimento objConta = new ContaInvestimento();

            return objConta.RetornarListaClientes();
        }

        // GET api/<ContaInvestimentoController>/5
        [HttpGet("{id}")]
        public ContaInvestimento Get(int id)
        {
            ContaInvestimento objConta = new ContaInvestimento();

            var lstContas = objConta.RetornarListaClientes();

            foreach (var conta in lstContas)
            {
                if(conta.ID == id)
                {
                    objConta =  conta;
                    break;
                }

            }
            return objConta;
        }

        // POST api/<ContaInvestimentoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ContaInvestimentoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContaInvestimentoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
