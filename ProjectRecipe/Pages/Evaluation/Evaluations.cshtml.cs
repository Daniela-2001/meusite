using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages.Evaluation
{
    public class EvaluationsModel : PageModel
    {
        public List<Evaluations> ListaAvaliacao = new List<Evaluations>();

        private IEvaluationServices novoAvaliacao = new EvaluationsServices();

        public void OnGet()
        {
            ListaAvaliacao = novoAvaliacao.GetAll();
        }

        public IActionResult OnPost(string IdDeletar)
        {
            int deletar = Convert.ToInt32(IdDeletar);

            if (deletar > 0)
            {
                var deletadoOk = novoAvaliacao.Delete(deletar);
                if (deletadoOk == false)
                {
                    //Fazer rotina de tratamento de erro
                }
            }

            return RedirectToPage("/Evaluation/Evaluations");
        }
    }
}
