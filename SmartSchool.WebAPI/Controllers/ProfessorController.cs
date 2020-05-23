//using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        private readonly SmartContext _context;

        public ProfessorController(SmartContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Professores);
        }
/*
        [HttpGet("{id:int}")] //id: int este espaço dá erro
        //        [ProducesResponseType(StatusCodes.Status201Created)]
        //        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetById(int id)
        {
            var professor = Professores.FirstOrDefault(a => a.Id == id);
            if (professor == null) return BadRequest("Professor não encontrado");
            return Ok(professor);
        }
*/
        [HttpGet("byid")] //com select query string /byid?id=1
        public IActionResult GetById(int id)
        {
            var professor = _context.Professores.FirstOrDefault(a => a.Id == id);
            if (professor == null) return BadRequest("Professor não encontrado");
            return Ok(professor);
        }

        [HttpGet("{nome}")] //:string dá erro not resolved
        public IActionResult GetByName(string nome)
        {
//            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome));
            var professor = _context.Professores.FirstOrDefault(a => a.Nome.Contains(nome));
            if (professor == null) return BadRequest("Professor não encontrado");
            return Ok(professor);
        }

        [HttpPost()] //inclusão de registro
        public IActionResult Post(Professor professor)
        {
            _context.Add(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpPut("{id}")] //atualização de registro por completo
        public IActionResult Put(int id, Professor professor)
        {
            var professorP = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (professorP == null) return BadRequest("Professor não encontrado");
            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpPatch("{id}")] //atualização de registro parcialmente
        public IActionResult Patch(int id, Professor professor)
        {
            var professorP = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (professorP == null) return BadRequest("Professor não encontrado");
            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpDelete("{id}")] //exclusão de registro
        public IActionResult Delete(int id)
        {
            var professorD = _context.Professores.FirstOrDefault(a => a.Id == id);
            if (professorD == null) return BadRequest("Professor não encontrado");
            _context.Remove(professorD);
            _context.SaveChanges();
            return Ok("Professor excluído");
        }
    }
}
