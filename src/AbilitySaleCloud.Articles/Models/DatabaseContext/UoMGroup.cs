using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AbilitySaleCloud.Articles.Models.DatabaseContext.Base;
using Microsoft.EntityFrameworkCore;

namespace AbilitySaleCloud.Articles.Models.DatabaseContext
{
    public class UoMGroup : DeletableEntity
    {
        [Key, StringLength(50)]
        public string UoMID { get; set; }

        [Required, StringLength(150)]
        public string UoMDescription { get; set; }

        [Required]
        public bool Locked { get; set; } //can it be used; 0 - Not locked = Default


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

		[StringLength(20)]
		public string IntrntSmbl { get; set; } //International symbol
    }
}