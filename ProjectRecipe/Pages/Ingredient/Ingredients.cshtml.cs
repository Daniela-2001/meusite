using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Repository.Interface;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages.Ingredient
{
    public class IngredientsModel : PageModel
    {
        public List<Ingredients> ListaIngredientes = new List<Ingredients>();

        private IIngredientsServices novoIngrediente = new IngredientsServices();
        public int IdRecipeSelecionada { get; set; }    
        public void OnGet(int id)
        {
            IdRecipeSelecionada = id;

            ListaIngredientes = novoIngrediente.GetAllIdRecipe(id);
        }

        public IActionResult OnPost(string IdDeletar)
        {
            string idRecipe = Request.Form["id-recipe"];
            int deletar = Convert.ToInt32(IdDeletar);

            if (deletar > 0)
            { 
                var deletadoOk = novoIngrediente.Delete(deletar);
                if (deletadoOk == false)
                {
                    //Fazer rotina de tratamento de erro
                }
            }
            return RedirectToPage("/Ingredient/Ingredients", new { id = idRecipe });
            //return RedirectToPage("/Ingredient/Ingredients");
        }
    }
}
