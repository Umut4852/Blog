﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog_Core.Entities;


namespace Blog_Entity.Entities
{
    public class Category : EntityBase
    {

        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
