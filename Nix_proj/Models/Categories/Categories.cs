﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_proj.Models.Categories
{
    class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Products> Items { get; set; }

    }
}
