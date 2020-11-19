using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AbilitySaleCloud.Articles.Models.DatabaseContext.Base;
using Microsoft.EntityFrameworkCore;

namespace AbilitySaleCloud.Articles.Models.DatabaseContext
{
    public class ArticleGroups : DeletableEntity
    {
        [Key]
        public int GroupID { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [Required]
        public bool Locked { get; set; } // can it be used; 0 - Not locked = Default

        [Required]
        public bool Alert { get; set; } //do the user needs an alert for min or max quantity from this group; Default = 0

        [Required]
        public bool OrderMultiple { get; set; }//Default = 0

        [Column(TypeName = "decimal(9, 2)")]
        public decimal MinOrdrQty { get; set; }

        [ForeignKey("UoMGroups")]
        public int DfltUoM { get; set; }

        public int ToleranceDays { get; set; }

        public bool RawMaterial { get; set; } //Default = 0 - no
    }
}