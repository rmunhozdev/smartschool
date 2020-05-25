using System;

namespace SmartSchool.WebAPI.Models
{
    public class AlunoCurso
    {
        public AlunoCurso() { }
        public AlunoCurso(int alunoid, int cursoId)
        {
            this.AlunoId = alunoid;
            this.CursoId = cursoId;
        }
        public DateTime DataIni { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; } = null;
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
