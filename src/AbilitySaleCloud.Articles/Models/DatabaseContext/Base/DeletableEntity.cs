using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbilitySaleCloud.Articles.Models.DatabaseContext.Base
{
    public class DeletableEntity : Entity, IDeletableEntity
    {
        public DateTime? DeletedOn { get; set; }

        public string DeletedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}
