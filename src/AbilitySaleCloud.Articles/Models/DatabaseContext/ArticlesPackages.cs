using System;
using Microsoft.EntityFrameworkCore;

namespace AbilitySaleCloud.Articles.Models.DatabaseContext
{
    public class ArticlesPackages
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Entry { get; set; }

        [ForeignKey("Articles")]
        public int ArticleID { get; set; }

        [Required, StringLength(1)]
        public string UoMType { get; set; } //P - Purchase; S - Sales; I - Inventory; Default = S

        [Required, ForeignKey("UoMGroups")]
        public int UoMGroupID { get; set; }

        [Column(TypeName = "decimal(9, 2)")]
        public decimal Height { get; set; }

        public int HeightUoM { get; set; }

        [Column(TypeName = "decimal(9, 2)")]
        public decimal Height2 { get; set; }

        public int HeightUoM2 { get; set; }

        [Column(TypeName = "decimal(9, 2)")]
        public decimal Width { get; set; }

        public int WidthUoM { get; set; }

        [Column(TypeName = "decimal(9, 2)")]
        public decimal Width2 { get; set; }

        public int WidthUoM2 { get; set; }

        [Column(TypeName = "decimal(9, 2)")]
        public decimal Length { get; set; }

        public int LengthUoM { get; set; }

        [Column(TypeName = "decimal(9, 2)")]
        public decimal Length2 { get; set; }

        public int LengthUoM2 { get; set; }

        [Column(TypeName = "decimal(9, 2)")]
        public decimal Volume { get; set; }

        public int VolumeUoM { get; set; }

        [Column(TypeName = "decimal(9, 2)")]
        public decimal Volume2 { get; set; }

        public int VolumeUoM2 { get; set; }

        [Column(TypeName = "decimal(9, 2)")]
        public decimal Weight { get; set; }

        public int WeightUoM { get; set; }

        [Column(TypeName = "decimal(9, 2)")]
        public decimal Weight2 { get; set; }

        public int WeightUoM2 { get; set; }

        [Required, Column(TypeName = "decimal(9, 2)")]
        public decimal QtyPerPack { get; set; }
    }
}
