namespace InscricaoApp.Domain.Entities
{
    public class Participante
    {
        public int CodPar { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public int PacoteId { get; set; }
        public Pacote Pacote { get; set; }
        public ICollection<ParticipanteAtividade> ParticipanteAtividades { get; set; }
    }
}