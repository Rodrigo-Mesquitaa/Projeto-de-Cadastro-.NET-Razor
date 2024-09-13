namespace InscricaoApp.Domain.Entities
{
    public class ParticipanteAtividade
    {
        public int ParticipanteId { get; set; }
        public Participante Participante { get; set; }

        public int AtividadeId { get; set; }
        public Atividade Atividade { get; set; }
    }
}