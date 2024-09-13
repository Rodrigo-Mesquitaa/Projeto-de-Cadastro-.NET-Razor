namespace InscricaoApp.Domain.Entities
{
    public class Pacote
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        // Lista de participantes associados a este pacote
        public ICollection<Participante> Participantes { get; set; } = new List<Participante>();
    }
}
