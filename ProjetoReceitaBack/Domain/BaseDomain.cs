﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectRecipeBack.Domain
{
    public class BaseDomain
    {
        public int Id { get; set; }
        public DateTime DateRegister => DateTime.Now;

    }
}
