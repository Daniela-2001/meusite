﻿using ProjectRecipeBack.Domain;
using ProjectRecipeBack.Repository.Repository;
using ProjectRecipeBack.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRecipeBack.Services.Services
{
    public class IngredientsServices : IIngredientsServices
    {
        public readonly IngredientsRepository Instance = new IngredientsRepository();
        public int Add(Ingredients ingrediente)
        {
            if (ingrediente == null) 
            { 
                return -1;
            }

            return Instance.Add(ingrediente);
        }

        public bool Delete(int id)
        {
            if (id <= 0)
            {
                return false;
            }

            return Instance.Delete(id);
        }

        public bool DeleteId(int id)
        {
           return Delete(id);
        }

        public Ingredients Get(int id)
        {
            if(id <= 0)
            {
                return null;
            }

            return Instance.Get(id);
        }

        public List<Ingredients> GetAll()
        {
            return Instance.GetAll();
        }

        public List<Ingredients> GetAllIdRecipe(int IdRecipe)
        {
            return Instance.GetAllIdRecipe(IdRecipe);   
        }

        public Ingredients Update(Ingredients ingrediente)
        {
            if(ingrediente == null)
            {
                return null;
            }

            return Instance.Update(ingrediente);
        }
    }
}
