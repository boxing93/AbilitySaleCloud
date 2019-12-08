using System;
using Microsoft.EntityFrameworkCore;

namespace AbilitySaleCloud.Articles.Models.DatabaseContext
{
    public class ArticlesPrices
    { 
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Entry { get; set; }

        [ForeignKey("Articles")]
        public int ArticleID { get; set; }

        [ForeignKey("PriceLists")]
        public int PriceList { get; set; }

        [Column(TypeName = "decimal(9, 2)")]
        public double Price { get; set; }

        [DataType(DataType.Currency), StringLength(3)]
        public string Currency { get; set; }

        [Required]
        public bool Overwritten { get; set; } //is it manually entered

        [Column(TypeName = "decimal(9, 2)")]
        public double AddPrice { get; set; } //Additional price 1

        [DataType(DataType.Currency), StringLength(3)]
        public string AddCurrency { get; set; }

        public bool Ovrwrttn { get; set; }

        [Column(TypeName = "decimal(9, 2)")]
        public double AddPrice2 { get; set; }

        [DataType(DataType.Currency), StringLength(3)]
        public string AddCurrency2 { get; set; }

        public bool Ovrwrttn2 { get; set; }

        [ForeignKey("UoMGroups"), Required, StringLength(6)]
        public string UoMEntryID { get; set; }

        [Required, StringLength(1)]
        public string PriceType { get; set; } //Default = M; I=Inventory UoM Price, M=Both I and P, O=Other UoM Price, P=Pricing Unit Price
    }
}
