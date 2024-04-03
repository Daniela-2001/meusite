using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages.Category
{
    public class CategoryCreateModel : PageModel
    {
        private ICategoriesServices _servicos = new CategoriesServices();

        [BindProperty]

        public Categories novoDado { set; get; }
        public void OnGet()
        {
            novoDado = new Categories();
        }
        public IActionResult OnPost() 
        {
            _servicos.Add(novoDado);
            return RedirectToPage("/Category/Categories");

        }
    }
}
