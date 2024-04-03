using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Repository.Repository;
using ProjectRecipeBack.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRecipeBack.Services.Services
{
    public class UsersServices : IUsersServices
    {
        public readonly UsersRepository Instance = new UsersRepository();   
        public int Add(Users usuario)
        {
            if (usuario == null)
            {
                return -1;
            }

            return Instance.Add(usuario);

        }

        public bool Delete(int id)
        {
            if (id<=0)
            {
                return false;
            }

            return Instance.Delete(id); 
        }

        public bool DeleteId(int id)
        {
            return Delete(id);
        }

        public Users Get(int id)
        {
            if(id<=0)
            {
                return null;
            }

            return Instance.Get(id);
        }

        public List<Users> GetAll()
        {
            return Instance.GetAll();
        }

        public Users LoginUser(string email, string senha)
        {
            return Instance.LoginUser(email, senha);
        }

        public Users Update(Users usuario)
        {
            if(usuario == null)
            {
                return null;
            }

            return Instance.Update(usuario);
        }
    }
}
