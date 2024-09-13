using InscricaoApp.Web.Models;
using InscricaoApp.Web.Pages.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InscricaoApp.Web.Pages.Participantes
{
    public class IndexModel : PageModel
    {
        private readonly ApiService _apiService;

        public IndexModel(ApiService apiService)
        {
            _apiService = apiService;
        }

        public IEnumerable<Participante> Participantes { get; set; }

        public async Task OnGetAsync()
        {
            Participantes = await _apiService.GetParticipantesAsync();
        }
    }
}