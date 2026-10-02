namespace ApiTreino.Models
{
    public class Processo
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public ICollection<Intervencao> Intervencoes { get; set; }
    }
}
