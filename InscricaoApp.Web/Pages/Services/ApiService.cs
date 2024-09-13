using InscricaoApp.Web.Models;

namespace InscricaoApp.Web.Pages.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            // Defina o endereço base para a API (verifique se a porta está correta)
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7015/"); // Endereço da API
        }
        // Exemplo de método para buscar a lista de participantes
        public async Task<List<Participante>> GetParticipantesAsync()
        {
            var response = await _httpClient.GetAsync("api/participantes");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<Participante>>();
        }

        // Exemplo de método para buscar um único participante pelo ID
        public async Task<Participante> GetParticipanteByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/participantes/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Participante>();
        }

        // Implementa o método para buscar a lista de pacotes
        public async Task<IEnumerable<Pacote>> GetPacotesAsync()
        {
            var response = await _httpClient.GetAsync("api/pacotes");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<Pacote>>();
        }

        // Implementa o método para buscar a lista de atividades
        public async Task<IEnumerable<Atividade>> GetAtividadesAsync()
        {
            var response = await _httpClient.GetAsync("api/atividades");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<Atividade>>();
        }

        // Implementa o método para adicionar um novo participante
        public async Task AddParticipanteAsync(Participante participante)
        {
            var response = await _httpClient.PostAsJsonAsync("api/participantes", participante);
            response.EnsureSuccessStatusCode();
        }

        // Implementa o método para criar um novo pacote
        public async Task CreatePacoteAsync(Pacote pacote)
        {
            var response = await _httpClient.PostAsJsonAsync("api/pacotes", pacote);
            response.EnsureSuccessStatusCode();
        }

        // Implementa o método para criar uma nova atividade
        public async Task CreateAtividadeAsync(Atividade atividade)
        {
            var response = await _httpClient.PostAsJsonAsync("api/atividades", atividade);
            response.EnsureSuccessStatusCode();
        }

        internal async Task CreatePacoteAsync(Domain.Entities.Pacote pacote)
        {
            throw new NotImplementedException();
        }
    }
}