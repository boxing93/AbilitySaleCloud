using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbilitySaleCloud.Articles.Models.DatabaseContext
{
    public class Articles
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

        public bool TaxLiable { get; set; }

        public bool IsSalesItem { get; set; }

        public bool IsPurchaseItem { get; set; }

        public bool IsInvItem { get; set; }

        public double QtySold { get; set; } //продадено количество от създаването на артикула

        public double QtyOrdered { get; set; } //поръчано поличество от създаването на артикула

        public double MaxInvLvl { get; set; } //Максимална запасеност от артикула

        public int DfltWrhs { get; set; } //Склад по подразбиране, в който се помещава артикула
        
        public int PrefVendor { get; set; } //Доставчик по подразбиране, от който се поръчва артикула

        [ForeignKey("UoMGroups"), Required, StringLength(6)]
        public string UoMGroupID { get; set; }

        [StringLength(50)]
        public string UoMPrchs { get; set; } //Тегловна единица при поръчка

        [StringLength(50)]
        public string UoMSales { get; set; } //Тегловна единица при продажба

        [StringLength(50)]
        public string UoMInv { get; set; } //Тегловна единица в склад

        [Required]
        public bool IsCanceled { get; set; } //Активен ли е все още артикула

        public double SpclDscnt { get; set; } //Отстъпка за артикул по default

        public int DscntCode { get; set; } //Код на отстъпката

        public double OpenBlnc { get; set; } //Обща наличност на артикул по всички складове

        [Required]
        public int LstUserID { get; set; } //Последния модифицирал потребител. Да се попълва от backend-a

        [StringLength(200)]
        [DataType(DataType.ImageUrl)]
        public string Picture { get; set; }

        [StringLength(250)]
        public string UserRemarks { get; set; }

        [Required]
        public double LastPrchsPrice { get; set; } //Да се попълва 0 при първо вписване на артикула

        [Required, DataType(DataType.Currency)]
        public decimal LastPrchsCurr { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime LastPrchsDT { get; set; }

        [Required]
        public double LastSalePrice { get; set; } //Да се попълва 0 при първо вписване на артикула

        [Required, DataType(DataType.Currency)]
        public decimal LastSaleCurr { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime LastSaleDT { get; set; }

        public double IssuePrice { get; set; } //Когато се терминира артикула се попълва

        [DataType(DataType.Currency)]
        public decimal IssueCurr { get; set; } 

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime IssueDT { get; set; }

        [StringLength(10)]
        public string IssueWarehouse { get; set; }

        public int ManufID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime UpdateDate { get; set; }

        public double AvgPrice { get; set; }

        public bool IsFrozen { get; set; } //0 - Не се поръчва и продава за период

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FrozenFrom { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FrozenTo { get; set; }

        [StringLength(50)]
        public string CountryOrigin { get; set; }
    }
}