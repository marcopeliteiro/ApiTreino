namespace ApiTreino.Models
{
    public class Intervencao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int ProcessoId { get; set; }
        public Processo Processo { get; set; }
        public ICollection<AnexoIntervencao> Anexos { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
    }
}
