using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Blog_Entity.Entities
{
    public class Article :Blog_Core.Entities.EntityBase
    {

        public string Title { get; set; }
        public string ViewCount { get; set; }
        public string Contect { get; set; }

        public Guid Categoryıd { get; set; }
        public Category Category { get; set; }

        public Guid ImageId { get; set; }
        public Image Image { get; set; }
    }
}
