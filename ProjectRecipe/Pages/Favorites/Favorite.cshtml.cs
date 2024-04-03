using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain.Enum;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages.Favorites
{
    public class FavoriteModel : PageModel
    {
        public List<Recipes> ListaReceita = new List<Recipes>();
        private IRecipesServices novoReceita = new RecipesServices();

        public void OnGet()
        {
            ListaReceita = novoReceita.GetAll();
        }

        public IActionResult OnPost(int idAvaliar)
        {
            FavoriteEnum favorito = FavoriteEnum.Favorite;

            if (Request.Form.ContainsKey("Favorite"))
            {
                favorito = FavoriteEnum.NoFavorite;
            }

            Recipes mudarEval;
            mudarEval = novoReceita.Get(idAvaliar);
            mudarEval.Favorite = favorito;
            novoReceita.Update(mudarEval);

            return RedirectToPage("/Favorites/Favorite");
        }
    }
}
