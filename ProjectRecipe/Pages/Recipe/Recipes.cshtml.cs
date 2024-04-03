using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages.Recipe
{
    public class RecipesModel : PageModel
    {
        public List<Recipes> ListaReceitas = new List<Recipes>();

        private IRecipesServices novoReceita = new RecipesServices();

        public void OnGet()
        {
            ListaReceitas = novoReceita.GetAll();
        }

        public IActionResult OnPost(string IdDeletar)
        {
            int deletar = Convert.ToInt32(IdDeletar);

            if (deletar > 0)
            {
                var deletadoOk = novoReceita.Delete(deletar);
                if (deletadoOk == false)
                {
                    //Fazer rotina de tratamento de erro
                }
            }

            return RedirectToPage("/Recipe/Recipes");
        }
    }
}
