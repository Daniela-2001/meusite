using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages.Difficulty
{
    public class DifficultiesModel : PageModel
    {
        public List<Difficulties> ListaGeral = new List<Difficulties>();

        private IDifficultiesServices novoItem = new DifficultiesServices();

        public void OnGet()
        {
            ListaGeral = novoItem.GetAll();
        }

        public IActionResult OnPost(string IdDeletar)
        {
            int deletar = Convert.ToInt32(IdDeletar);

            if (deletar > 0)
            {
                var deletadoOk = novoItem.Delete(deletar);
                if (deletadoOk == false)
                {
                    //Fazer rotina de tratamento de erro
                }
            }

            return RedirectToPage("/Difficulty/Difficulties");
        }
    }
}
