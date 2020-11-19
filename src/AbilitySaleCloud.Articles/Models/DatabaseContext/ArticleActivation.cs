using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AbilitySaleCloud.Articles.Models.DatabaseContext.Base;
using Microsoft.EntityFrameworkCore;

namespace AbilitySaleCloud.Articles.Models.DatabaseContext
{
    public class ArticleActivation : Entity
    {

        [Key, ForeignKey("Articles")]
        public int ArticlesID { get; set; }

        [Required]
        public bool IsCanceled { get; set; } //Is this article active

        public double IssuePrice { get; set; } //Filling on termination

        [DataType(DataType.Currency), StringLength(3)]
        public string IssueCurr { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime IssueDT { get; set; }

        [StringLength(10)]
        public string IssueWarehouse { get; set; }

        public bool IsFrozen { get; set; } //0 - not meant to purchase or sale for a particular period

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FrozenFrom { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FrozenTo { get; set; }
    }
}
