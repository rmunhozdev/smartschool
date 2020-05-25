using System;

namespace SmartSchool.WebAPI.Dtos
{
    public class AlunoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public DateTime DataIni { get; set; }
        public DateTime? DataFim { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
