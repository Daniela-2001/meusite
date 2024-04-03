using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages.User
{
    public class UsersCreateModel : PageModel
    {
        private IUsersServices _servicos = new UsersServices();

        [BindProperty]

        public Users novoDado { set; get; }
        public void OnGet()
        {
            novoDado = new Users();
        }

        public IActionResult OnPost()
        {
            _servicos.Add(novoDado);
            return RedirectToPage("/User/Users");
        }
    }
}
