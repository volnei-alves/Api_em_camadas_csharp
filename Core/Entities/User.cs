﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entidades
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
