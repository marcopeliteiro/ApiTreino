namespace ApiTreino.Models
{
    public class Estado
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public ICollection<Processo> Processos { get; set; }
        public ICollection<Intervencao> Intervencoes { get; set; }
    }
}
