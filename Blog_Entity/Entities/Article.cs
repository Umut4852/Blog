using Blog_Core.Entities;

namespace Blog_Entity.Entities
{
    public class Article :EntityBase
    {

        public string Title { get; set; }
        public int ViewCount { get; set; }
        public string Contect { get; set; }

        public Guid Categoryıd { get; set; }
        public Category Category { get; set; }

        public Guid ImageId { get; set; }
        public Image Image { get; set; }
    }
}

