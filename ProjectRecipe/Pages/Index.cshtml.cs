using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Domain.Enum;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Recipes> ListaReceita;

        private readonly IRecipesServices _recipesServices = new RecipesServices();

        public IndexModel(ILogger<IndexModel> logger)
        {
            //ListaReceita = _recipesServices.GetAll();
            ListaReceita = _recipesServices.GetAllApproved();

            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}