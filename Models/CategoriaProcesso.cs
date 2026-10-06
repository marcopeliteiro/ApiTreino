namespace ApiTreino.Models
{
    public class CategoriaProcesso
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        ICollection<Processo> Processos { get; set; }
    }
}
