using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Categories> ListaCategorias = new List<Categories>();

        private ICategoriesServices novaCategoria = new CategoriesServices();

        public void OnGet()
        { 
            ListaCategorias = novaCategoria.GetAll();
        }

        public IActionResult OnPost(string IdDeletar)
        {
            int deletar = Convert.ToInt32(IdDeletar);

            if(deletar > 0) 
            { 
                var deletadoOk =  novaCategoria.Delete(deletar);
                if(deletadoOk == false)
                {
                    //Fazer rotina de tratamento de erro
                }
            }

            return RedirectToPage("/Category/Categories");
        }
    }
}
