using InscricaoApp.Web.Models;
using InscricaoApp.Web.Pages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InscricaoApp.Web.Pages.Participantes
{
    public class CreateModel : PageModel
    {
        private readonly ApiService _apiService;

        public CreateModel(ApiService apiService)
        {
            _apiService = apiService;
        }

        [BindProperty]
        public Participante Participante { get; set; }
        public IEnumerable<Pacote> Pacotes { get; set; }
        public IEnumerable<Atividade> Atividades { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Pacotes = await _apiService.GetPacotesAsync();
            Atividades = await _apiService.GetAtividadesAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Pacotes = await _apiService.GetPacotesAsync();
                Atividades = await _apiService.GetAtividadesAsync();
                return Page();
            }

            await _apiService.AddParticipanteAsync(Participante);
            return RedirectToPage("Index");
        }
    }
}