using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;
using System.Collections.Generic;

namespace ProjectRecipe.Pages.Recipe
{
    public class RecipeCreateModel : PageModel
    {
        private IRecipesServices _servicos = new RecipesServices();

        private IDifficultiesServices _difficulties = new DifficultiesServices();

        private ICategoriesServices _categories = new CategoriesServices();


        [BindProperty]

        public Recipes novoDado { set; get; }
        public List<Difficulties> dadosDifficulty { set; get; }

        public List<Categories> dadosCategory { set; get; }
        public void OnGet()
        {
            dadosDifficulty = _difficulties.GetAll();

            dadosCategory = _categories.GetAll();   

            novoDado = new Recipes();
        }

        public IActionResult OnPost()
        {
            _servicos.Add(novoDado);
            return RedirectToPage("/Recipe/Recipes");
        }
    }
}
