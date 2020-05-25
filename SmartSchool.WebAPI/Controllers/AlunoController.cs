//using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Dtos;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
//        private readonly SmartContext _context;
        public readonly IRepository _repo;
        private readonly IMapper _mapper;

        //        public AlunoController(SmartContext context, IRepository repo)
        public AlunoController(IRepository repo, IMapper mapper)
        {
//            this.context = context;

//            _context = context;
            _repo = repo;
            _mapper = mapper;
        }
        /*
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
        */
        [HttpGet]
//        [ProducesResponseType(StatusCodes.Status201Created)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Get()
        {
//            return Ok(Alunos);

//            return Ok(_context.Alunos);
            var result = _repo.GetAllAlunos(true);

//utilizar o AutoMapper
/*
            var alunosRetorno = new List<AlunoDTO>();

            foreach (var aluno in result)
            {
                alunosRetorno.Add(new AlunoDTO() {
                    Id = aluno.Id,
                    Matricula = aluno.Matricula,
                    Nome = $"{aluno.Nome} {aluno.Sobrenome}",
                    Telefone = aluno.Telefone,
                    DataNasc = aluno.DataNasc,
                    DataIni = aluno.DataIni,
                    Ativo = aluno.Ativo
                });
            }
*/

//            return Ok(result);
//            return Ok(alunosRetorno);
            return Ok(_mapper.Map<IEnumerable<AlunoDTO>>(result));
        }

        ///// só para pegar o Objeto cru para testar
        [HttpGet("getRegister")]
        public IActionResult GetRegister()
        {
            var result = _repo.GetAllAlunos(true);
            return Ok(new AlunoRegistrarDTO());
        }
        /////

        [HttpGet("pegaResposta")]
        public IActionResult pegaResposta()
        {
            //            return Ok(Alunos);
            return Ok(_repo.pegaResposta());
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

//        [HttpGet("byid")] //com select query string /byid?id=1
        [HttpGet("{id}")] //com select query string /byid?id=1
        public IActionResult GetById(int id)
        {
//            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
//            var aluno = _context.Alunos.FirstOrDefault(a => a.Id == id);
            var aluno = _repo.GetAlunoById(id);
            if (aluno == null) return BadRequest("Aluno não encontrado");

            var aluDto = _mapper.Map<AlunoDTO>(aluno);

//            return Ok(aluno);
            return Ok(aluDto);
        }

/*
        [HttpGet("{nome}")] //:string dá erro not resolved
        public IActionResult GetByName(string nome)
        {
//            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome));
            var aluno = _context.Alunos.FirstOrDefault(a => a.Nome.Contains(nome));
            if (aluno == null) return BadRequest("Aluno não encontrado");
            return Ok(aluno);
        }
*/

        [HttpPost()] //inclusão de registro
//        public IActionResult Post(Aluno aluno)
//        public IActionResult Post(AlunoDTO alu)
        public IActionResult Post(AlunoRegistrarDTO alu)
        {
            var aluno = _mapper.Map<Aluno>(alu);
            _repo.Add(aluno);
            if (_repo.SaveChanges())
            {
//                return Ok(aluno);
                return Created($"/api/aluno/{alu.Id}", _mapper.Map<AlunoDTO>(aluno)); //retorna 201 criado
            }
            else
            {
                return BadRequest("Aluno não cadastrado");
            }
//            _context.Add(aluno);
//            _context.SaveChanges();
//            return Ok(aluno);
        }

        [HttpPut("{id}")] //atualização de registro por completo
//        public IActionResult Put(int id, Aluno aluno)
//        public IActionResult Put(int id, AlunoDTO alu)
        public IActionResult Put(int id, AlunoRegistrarDTO alu)
        {
//            var alunoP = _context.Alunos.AsNoTracking().FirstOrDefault(a => a.Id == id);
            var alunoP = _repo.GetAlunoById(id);
            if (alunoP == null) return BadRequest("Aluno não encontrado");

            _mapper.Map(alu, alunoP);

//            _repo.Update(alunoP);
            _repo.Update(alunoP);
            if (_repo.SaveChanges())
            {
//                return Ok(aluno);
                return Created($"/api/aluno/{alu.Id}", _mapper.Map<AlunoDTO>(alunoP)); //retorna 201 criado
            }
            else
            {
                return BadRequest("Aluno não atualizado");
            }

//            _context.Update(aluno);
//            _context.SaveChanges();
//            return Ok(aluno);
        }

        [HttpPatch("{id}")] //atualização de registro parcialmente
//        public IActionResult Put(int id, Aluno aluno)
//        public IActionResult Patch(int id, AlunoDTO alu)
        public IActionResult Patch(int id, AlunoRegistrarDTO alu)
        {
//            var alunoP = _context.Alunos.AsNoTracking().FirstOrDefault(a => a.Id == id);
            var alunoP = _repo.GetAlunoById(id);
            if (alunoP == null) return BadRequest("Aluno não encontrado");

            _mapper.Map(alu, alunoP);

//            _repo.Update(aluno);
            _repo.Update(alunoP);
            if (_repo.SaveChanges())
            {
//                return Ok(aluno);
                return Created($"/api/aluno/{alu.Id}", _mapper.Map<AlunoDTO>(alunoP)); //retorna 201 criado
            }
            else
            {
                return BadRequest("Aluno não atualizado");
            }

//            _context.Update(aluno);
//            _context.SaveChanges();
//            return Ok(aluno);
        }

        [HttpDelete("{id}")] //exclusão de registro
        public IActionResult Delete(int id)
        {
//            var alunoD = _context.Alunos.FirstOrDefault(a => a.Id == id);
            var alunoD = _repo.GetAlunoById(id);
            if (alunoD == null) return BadRequest("Aluno não encontrado");

            _repo.Delete(alunoD);
            if (_repo.SaveChanges())
            {
                return Ok("Aluno deletado");
            }
            else
            {
                return BadRequest("Aluno não deletado");
            }

//            _context.Remove(alunoD);
//            _context.SaveChanges();
//            return Ok("Aluno excluído");
        }
    }
}
