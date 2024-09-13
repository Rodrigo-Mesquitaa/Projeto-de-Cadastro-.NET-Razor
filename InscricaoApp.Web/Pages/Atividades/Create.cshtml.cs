using InscricaoApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InscricaoApp.Web.Pages.Services;

namespace InscricaoApp.Web.Pages.Atividades
{
    public class CreateModel : PageModel
    {
        private readonly ApiService _apiService;

        public CreateModel(ApiService apiService)
        {
            _apiService = apiService;
        }

        [BindProperty]
        public Atividade Atividade { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _apiService.CreateAtividadeAsync(Atividade);
            return RedirectToPage("Index");
        }
    }
}