using InscricaoApp.Web.Models;
using InscricaoApp.Web.Pages.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InscricaoApp.Web.Pages.Atividades
{
    public class IndexModel : PageModel
    {
        private readonly ApiService _apiService;

        public IndexModel(ApiService apiService)
        {
            _apiService = apiService;
        }

        public IEnumerable<Atividade> Atividades { get; set; }

        public async Task OnGetAsync()
        {
            Atividades = await _apiService.GetAtividadesAsync();
        }
    }
}