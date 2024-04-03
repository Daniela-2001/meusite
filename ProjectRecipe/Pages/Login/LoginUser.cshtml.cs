using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages.Login
{
    public class LoginUserModel : PageModel
    {
        private readonly IUsersServices usersServices = new UsersServices();
        public Users usuario = new Users();

        public void OnGet()
        {
        }
        public void OnPost(string Email, string Password) 
        {
            usuario = usersServices.LoginUser(Email, Password); 

            if(usuario != null)
            {
                Console.WriteLine("logado");
            }
            else
            {
                Console.WriteLine("Usuário não logado");
            }

        }    
    }
}
