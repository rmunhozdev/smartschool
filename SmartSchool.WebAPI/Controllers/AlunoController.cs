//using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>
        {
            new Aluno()
            {
                Id = 1,
                Nome = "Ricardo",
                Sobrenome = "Munhoz",
                Telefone = "11990909999"
            },
            new Aluno()
            {
                Id = 2,
                Nome = "Roberto",
                Sobrenome = "Munhoz",
                Telefone = "11990909999"
            },
            new Aluno()
            {
                Id = 3,
                Nome = "Rodrigo",
                Sobrenome = "Munhoz",
                Telefone = "11990909999"
            },
        };
        public AlunoController() { }

        [HttpGet]
//        [ProducesResponseType(StatusCodes.Status201Created)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }
/*
        [HttpGet("{id:int}")] //id: int este espaço dá erro
        //        [ProducesResponseType(StatusCodes.Status201Created)]
        //        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("Aluno não encontrado");
            return Ok(aluno);
        }
*/
        [HttpGet("byid")] //com select query string /byid?id=1
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("Aluno não encontrado");
            return Ok(aluno);
        }

        [HttpGet("{nome}")] //:string dá erro not resolved
        public IActionResult GetByName(string nome)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome));
            if (aluno == null) return BadRequest("Aluno não encontrado");
            return Ok(aluno);
        }

        [HttpPost()] //inclusão de registro
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")] //atualização de registro por completo
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }
/* verificar ...
        [HttpPatch("{id}")] //atualização de registro parcialmente
        public IActionResult Patch(int id, Delta<Aluno>) //Aluno aluno)
        {
            var altx = Alunos.FirstOrDefault(a => a.Id == id);
            if (altx == null) return BadRequest("Aluno não encontrado");
            aluno.Patch(altx);
            return Ok(aluno);
        }
*/
        [HttpDelete("{id}")] //exclusão de registro
        public IActionResult Delete(Aluno aluno)
        {
            return Ok("Registro excluído");
        }
    }
}
