using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages.Evaluation
{
    public class EvaluationUpdateModel : PageModel
    {
        private IEvaluationServices _servicos = new EvaluationsServices();

        [BindProperty]

        public Evaluations novoDado { set; get; }

        public void OnGet(int id)
        {
            novoDado = _servicos.Get(id);
        }
        public IActionResult OnPost()
        {
            _servicos.Update(novoDado);
            return RedirectToPage("/Evaluation/Evaluations");

        }
    }
}
