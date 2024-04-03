using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages.Evaluation
{
    public class EvaluationCreateModel : PageModel
    {
        private IEvaluationServices _servicos = new EvaluationsServices();

        [BindProperty]

        public Evaluations novoDado { set; get; }
        public void OnGet()
        {
            novoDado = new Evaluations();
        }

        public IActionResult OnPost()
        {
            _servicos.Add(novoDado);
            return RedirectToPage("/Evaluation/Evaluations");
        }
    }
}
