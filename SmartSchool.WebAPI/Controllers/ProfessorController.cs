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
        public readonly IRepository _repo;

        public ProfessorController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.GetAllProfessores());
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
        [HttpGet("{id}")] //com select query string /byid?id=1
        public IActionResult GetById(int id)
        {
            var professor = _repo.GetProfessorById(id);
            if (professor == null) return BadRequest("Professor não encontrado");
            return Ok(professor);
        }

        [HttpPost()] //inclusão de registro
        public IActionResult Post(Professor professor)
        {
            _repo.Add(professor);
            if (_repo.SaveChanges())
            {
                return Ok(professor);
            }
            else
            {
                return BadRequest("Professor não cadastrado");
            }
//            _context.Add(professor);
//            _context.SaveChanges();
//            return Ok(professor);
        }

        [HttpPut("{id}")] //atualização de registro por completo
        public IActionResult Put(int id, Professor professor)
        {
            var professorP = _repo.GetProfessorById(id, true);
            if (professorP == null) return BadRequest("Professor não encontrado");

            _repo.Update(professor);
            if (_repo.SaveChanges())
            {
                return Ok(professor);
            }
            else
            {
                return BadRequest("Professor não atualizado");
            }

//            _context.Update(professor);
//            _context.SaveChanges();
//            return Ok(professor);
        }

        [HttpPatch("{id}")] //atualização de registro parcialmente
        public IActionResult Patch(int id, Professor professor)
        {
            var professorP = _repo.GetProfessorById(id);
            if (professorP == null) return BadRequest("Professor não encontrado");

            _repo.Update(professor);
            if (_repo.SaveChanges())
            {
                return Ok(professor);
            }
            else
            {
                return BadRequest("Professor não atualizado");
            }

//            _context.Update(professor);
//            _context.SaveChanges();
//            return Ok(professor);
        }

        [HttpDelete("{id}")] //exclusão de registro
        public IActionResult Delete(int id)
        {
            var professorD = _repo.GetProfessorById(id);
            if (professorD == null) return BadRequest("Professor não encontrado");

            _repo.Delete(professorD);
            if (_repo.SaveChanges())
            {
                return Ok("Professor deletado");
            }
            else
            {
                return BadRequest("Professor não deletado");
            }

//            _context.Remove("Professor deletado");
//            _context.SaveChanges();
//            return Ok("Professor excluído");
        }
    }
}
