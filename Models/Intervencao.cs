namespace ApiTreino.Models
{
    public class Intervencao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int ProcessoId { get; set; }
        public Processo Processo { get; set; }
    }
}
