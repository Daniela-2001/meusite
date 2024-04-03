using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain.Enum;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages.PublishRecipe
{
    public class PublishRecModel : PageModel
    {
        public List<Recipes> ListaReceita = new List<Recipes>();
        private IRecipesServices novoReceita = new RecipesServices();

        public void OnGet()
        {
            ListaReceita = novoReceita.GetAll();
        }

        public IActionResult OnPost(int idAvaliar)
        {
            ApprovalEnum aprovado = ApprovalEnum.Approved;

            if (Request.Form.ContainsKey("aprovado"))
            {
                aprovado = ApprovalEnum.NoApproved;
            }

            Recipes mudarEval;
            mudarEval = novoReceita.Get(idAvaliar);
            mudarEval.Approval = aprovado;
            novoReceita.Update(mudarEval);

            return RedirectToPage("/PublishRecipe/PublishRec");
        }
    }
}
