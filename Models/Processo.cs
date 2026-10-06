namespace ApiTreino.Models
{
    public class Processo
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public ICollection<Intervencao> Intervencoes { get; set; }
        public ICollection<AnexoProcesso> Anexos { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
        public int CategoriaProcessoId { get; set; }
        public CategoriaProcesso CategoriaProcesso { get; set; }
    }
}
