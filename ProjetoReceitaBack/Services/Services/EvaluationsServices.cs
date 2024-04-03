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
    public class EvaluationsServices : IEvaluationServices
    {
        public readonly EvaluationsRepository Instance = new EvaluationsRepository();
        public int Add(Evaluations avaliacao)
        {
            if (avaliacao == null)
            {
                return -1;
            }

            return Instance.Add(avaliacao);
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

        public Evaluations Get(int id)
        {
            if(id<=0)
            {
                return null;
            }

            return Instance.Get(id);
        }

        public List<Evaluations> GetAll()
        {
            return Instance.GetAll();
        }

        public List<Evaluations> GetAllRecipeApproved(int id)
        {
            return Instance.GetAllRecipeApproved(id);   
        }

        public Evaluations Update(Evaluations avaliacao)
        {
            if(avaliacao == null)
            {
                return null;
            }

            return Instance.Update(avaliacao);
        }
    }
}
