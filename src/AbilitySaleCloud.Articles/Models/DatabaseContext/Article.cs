using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AbilitySaleCloud.Articles.Models.DatabaseContext.Base;

namespace AbilitySaleCloud.Articles.Models.DatabaseContext
{
    public class Article : DeletableEntity
    {
        [Key]
        public int ArticleID { get; set; }

        [Required, StringLength(100)]
        public string Description { get; set; }

        [StringLength(100)]
        public string ForeignName { get; set; }

        [ForeignKey("ArticleGroups"), Required]
        public int ArticleGroupID { get; set; }

        [ForeignKey("TaxGroups"), Required, StringLength(6)]
        public string TaxGroupID { get; set; }

        public double MaxInvLvl { get; set; } //Maximum inventory level from the article

        public int DfltWrhs { get; set; } //Default warehouse for this article
        
        public int PrefVendor { get; set; } //Default vendor for this article

        [ForeignKey("UoMGroups"), Required, StringLength(6)]
        public string UoMGroupID { get; set; }

        public double SpclDscnt { get; set; } //Отстъпка за артикул по default

        public int DscntCode { get; set; } //Код на отстъпката

        public double OpenBlnc { get; set; } //Обща наличност на артикул по всички складове

        [StringLength(200)]
        [DataType(DataType.ImageUrl)]
        public string Picture { get; set; }

        [StringLength(250)]
        public string UserRemarks { get; set; }

        public int ManufID { get; set; }

        public double AvgPrice { get; set; }

        [StringLength(50)]
        public string CountryOrigin { get; set; }
    }
}