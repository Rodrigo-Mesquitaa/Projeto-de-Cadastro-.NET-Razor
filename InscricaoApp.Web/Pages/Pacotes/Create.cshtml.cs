using InscricaoApp.Domain.Entities;
using InscricaoApp.Web.Pages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InscricaoApp.Web.Pages.Pacotes
{
    public class CreateModel : PageModel
    {
        private readonly ApiService _apiService;

        public CreateModel(ApiService apiService)
        {
            _apiService = apiService;
        }

        [BindProperty]
        public Pacote Pacote { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _apiService.CreatePacoteAsync(Pacote);
            return RedirectToPage("Index");
        }
    }
}