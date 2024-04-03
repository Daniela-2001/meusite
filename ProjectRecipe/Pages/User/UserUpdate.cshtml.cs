using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Services.Interface;
using ProjectRecipeBack.Services.Services;

namespace ProjectRecipe.Pages.User
{
    public class UserUpdateModel : PageModel
    {
        private IUsersServices _servicos = new UsersServices();

        [BindProperty]

        public Users novoDado { set; get; }

        public void OnGet(int id)
        {
            novoDado = _servicos.Get(id);
        }
        public IActionResult OnPost()
        {
            _servicos.Update(novoDado);
            return RedirectToPage("/User/Users");

        }
    }
}
