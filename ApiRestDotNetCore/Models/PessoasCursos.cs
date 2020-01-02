namespace ApiRestDotNetCore.Models
{
    public class PessoasCursos
    {
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
