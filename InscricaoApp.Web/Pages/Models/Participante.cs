namespace InscricaoApp.Web.Models
{
    public class Participante
    {
        public int CodPar { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public Pacote Pacote { get; set; }
    }
}