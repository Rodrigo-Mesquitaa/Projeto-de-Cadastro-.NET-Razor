namespace InscricaoApp.Api.DTOs
{
    public class ParticipanteDto
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public int PacoteId { get; set; }
    }
}