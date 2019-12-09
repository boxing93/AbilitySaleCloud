using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AbilitySaleCloud.Articles.Models.DatabaseContext
{
    public class ArticlesActivity
    {
        [Key, ForeignKey("Articles")]
        public int ArticleID { get; set; }

        public bool TaxLiable { get; set; }

        public bool IsSalesItem { get; set; }

        public bool IsPurchaseItem { get; set; }

        public bool IsInvItem { get; set; }

        public double QtySold { get; set; } //Quantity sold from the adding 

        public double QtyOrdered { get; set; } //Quantity ordered from the adding

        [ForeignKey("UoMGroups"), Required, StringLength(6)]
        public int UoMPrchsID { get; set; } //Unit of measure for purchase

        [ForeignKey("UoMGroups"), Required, StringLength(6)]
        public string UoMSalesID { get; set; } //Unit of measure for selling

        [ForeignKey("UoMGroups"), Required, StringLength(6)]
        public string UoMInvID { get; set; } //Warehouse unit of measure

        [Required]
        public double LastPrchsPrice { get; set; } //0 on creation

        [Required, DataType(DataType.Currency), StringLength(3)]
        public string LastPrchsCurr { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime LastPrchsDT { get; set; }

        [Required]
        public double LastSalePrice { get; set; } //0 on creation

        [Required, DataType(DataType.Currency), StringLength(3)]
        public string LastSaleCurr { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime LastSaleDT { get; set; }

    }
}