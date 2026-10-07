namespace ApiTreino.Models
{
    public class AnexoIntervencao
    {
        public int Id { get; set; }
        public int IntervencaoId { get; set; }
        public Intervencao Intervencao { get; set; }
        public string NomeFicheiro { get; set; }
        public string Url { get; set; }
    }
}
