using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages.Difficulty
{
    public class DifficultyUpdateModel : PageModel
    {
        private IDifficultiesServices _servicos = new DifficultiesServices();

        [BindProperty]

        public Difficulties novoDado { set; get; }

        public void OnGet(int id)
        {
            novoDado = _servicos.Get(id);
        }
        public IActionResult OnPost()
        {
            _servicos.Update(novoDado);
            return RedirectToPage("/Difficulty/Difficulties");

        }

    }
}
