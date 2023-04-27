using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Core.Entities
{
    public abstract class EntityBase : IEntityBase
    {
        public virtual string ad { get; set; }
        public virtual Guid Id { get; set; } = Guid.NewGuid();
        public virtual string DeleteBy { get; set; }
        public virtual string? ModifiedBy { get; set; }
        public virtual string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? UpdatedDate { get; }
        public bool IsDeleted { get; set; } = false;

    }
}
