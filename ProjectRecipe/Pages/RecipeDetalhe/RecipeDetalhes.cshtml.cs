using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Domain.Enum;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages.RecipeDetalhe
{
    public class RecipeDetalhesModel : PageModel
    {
        public readonly IRecipesServices _recipes = new RecipesServices();
        public readonly ICategoriesServices _categories = new CategoriesServices(); 
        public readonly IDifficultiesServices _difficulties = new DifficultiesServices();
        public readonly IIngredientsServices _ingredients = new IngredientsServices();
        public readonly IEvaluationServices _evoulation = new EvaluationsServices();

        public Recipes dadosRecipes { get; set; }
        public Categories dadosCategories { get; set; }
        public Difficulties dadosDifficulties { get; set; }
        public List<Ingredients> ListaIngredients { get; set; }
        public List<Evaluations> ListaEvaluations { get; set; }


        public void OnGet(int id)
        {
            dadosRecipes = _recipes.Get(id);

            dadosCategories = _categories.Get(dadosRecipes.IdCategory);

            dadosDifficulties = _difficulties.Get(dadosRecipes.IdDifficulty);
           
            ListaIngredients = _ingredients.GetAllIdRecipe(id);

            ListaEvaluations = _evoulation.GetAllRecipeApproved(id);

            //ListaEvaluations = _evoulation.GetAll();

        }

        public IActionResult OnPost()
        {

            string idCritica = Request.Form["id-critica"];
            string criticaRecipe = Request.Form["critica-recipe"];
            string gradeRecipe = Request.Form["grade-recipe"];

            int id = Int32.Parse(idCritica);
            // cria evaluction e atibui os valores
            Evaluations novaAvaliacao = new Evaluations();

            novaAvaliacao.IdRecipe = Int32.Parse(idCritica);
            novaAvaliacao.Name = criticaRecipe;

            if(Enum.TryParse<GradeEnum>(gradeRecipe, out GradeEnum gradeCorreto))
            {
                novaAvaliacao.Grade= gradeCorreto;
            }
            else
            {
                novaAvaliacao.Grade = GradeEnum.Nota_1;
            }
            novaAvaliacao.Approval = ProjectRecipeBack.Domain.Enum.ApprovalEnum.NoApproved;

            _evoulation.Add(novaAvaliacao);

            return RedirectToPage("/RecipeDetalhe/RecipeDetalhes", new { id = id });
        }

       



    }
}
