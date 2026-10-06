namespace ApiTreino.Models
{
    public class AnexoProcesso
    {
        public int Id { get; set; }
        public int ProcessoId { get; set; }
        public Processo Processo { get; set; }
        public string NomeFicheiro { get; set; }
        public string Url { get; set; }
    }
}
