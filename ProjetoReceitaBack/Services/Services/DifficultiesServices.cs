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
    public class DifficultiesServices : IDifficultiesServices
    {
        public readonly DifficultiesRepository Instance = new DifficultiesRepository();
        public int Add(Difficulties dificuldade)
        {
            if(dificuldade == null)
            {
                return -1;
            }

            return Instance.Add(dificuldade);   
        }

        public bool Delete(int id)
        {
            if(id <= 0)
            {
                return false;
            }

            return Instance.Delete(id);
        }

        public bool DeleteId(int id)
        {
            return Delete(id);
        }

        public Difficulties Get(int id)
        {
            if(id <= 0)
            {
                return null;
            }

            return Instance.Get(id);
        }

        public List<Difficulties> GetAll()
        {
            return Instance.GetAll();
        }

        public Difficulties Update(Difficulties dificuldade)
        {
            if(dificuldade == null)
            {
                return null;
            }

            return Instance.Update(dificuldade);

        }
    }
}
