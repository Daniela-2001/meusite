using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages.Ingredient
{
    public class IngredientUpdateModel : PageModel
    {
        private IIngredientsServices _servicos = new IngredientsServices();

        [BindProperty]

        public Ingredients novoDado { set; get; }

        public int idRecipe2;

        public void OnGet(int id)
        {
            novoDado = _servicos.Get(id);
            idRecipe2 = novoDado.IdRecipe;
        }
        public IActionResult OnPost(int idRecipe)
        {
            //string idVolta = Request.Form["IdRecipe"];
            _servicos.Update(novoDado);
            return RedirectToPage("/Ingredient/Ingredients", new { id = idRecipe });


        }
    }
}
