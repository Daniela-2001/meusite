using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages.User
{
    public class UsersModel : PageModel
    {
        public List<Users> ListaUsuarios = new List<Users>();

        private IUsersServices novoUsuario = new UsersServices();

        public void OnGet()
        {
            ListaUsuarios = novoUsuario.GetAll();
        }

        public IActionResult OnPost(string IdDeletar)
        {
            int deletar = Convert.ToInt32(IdDeletar);

            if(deletar > 0)
            {
                var deletadoOk = novoUsuario.Delete(deletar);
                if(deletadoOk == false)
                {
                    //Fazer rotina de tratamento de erro
                }
            }

            return RedirectToPage("/User/Users");
        }
    }
}
