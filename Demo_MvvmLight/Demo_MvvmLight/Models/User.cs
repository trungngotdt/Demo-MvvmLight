﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MvvmLight.Models
{
    public class User
    {
        public User()
        {

        }
        private string pass;

        private string name;

        public string Name { get => name; set => name = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}