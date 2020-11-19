using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AbilitySaleCloud.Articles.Models.DatabaseContext.Base;
using Microsoft.EntityFrameworkCore;

namespace AbilitySaleCloud.Articles.Models.DatabaseContext
{
    public class TaxGroup : DeletableEntity
    {
        [Key, StringLength(6)]
        public string TaxCode { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Required, Column(TypeName = "decimal(9, 2)")]
        public decimal Rate { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime EffectFrom { get; set; } //Effective from

        [Required, StringLength(1)]
        public string Type { get; set; }//Default = I; I - Input; O - Output;

        [Required]
        public bool Locked { get; set; }//Default = 0 - no; 1 - yes;

        public bool AcqstnRvrs { get; set; } // Acquisition/Reverse

        [Column(TypeName = "decimal(9, 2)")]
        public decimal NonDedct { get; set; } //Non deduction percent

        [Column(TypeName = "decimal(9, 2)")]
        public decimal EquVatPr { get; set; } //Equalization Tax %

        [Required]
        public bool TaxType { get; set; } //1=Stamp, 0=VAT; Default = 0
    }
}
