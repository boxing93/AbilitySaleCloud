using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbilitySaleCloud.Articles.Models.DatabaseContext.Base
{
    public interface IEntity
    {
        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string ModifiedBy { get; set; }
    }
}
