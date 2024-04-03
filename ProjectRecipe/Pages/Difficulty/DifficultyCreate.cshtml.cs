using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages.Difficulty
{
    public class DifficultyCreateModel : PageModel
    {
        private IDifficultiesServices _servicos = new DifficultiesServices();

        [BindProperty]

        public Difficulties novoDado { set; get; }
        public void OnGet()
        {
            novoDado = new Difficulties();
        }
        public IActionResult OnPost()
        {
            _servicos.Add(novoDado);
            return RedirectToPage("/Difficulty/Difficulties");

        }
    }
}
