namespace InscricaoApp.Domain.Entities
{
    public class Atividade
    {
        public int CodAtv { get; set; }
        public string DescAtv { get; set; }
        public int Vagas { get; set; }
        public decimal Preco { get; set; }
        public ICollection<ParticipanteAtividade> ParticipanteAtividades { get; set; }
        public int Id { get; set; }
    }
}