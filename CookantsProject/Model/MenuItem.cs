using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookantsEntity.Model
{
   public class MenuItem 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }


        #region ForeignKey Property

        [ForeignKey("MenuCategorys")]
        [Required]
        [Description("Relationships with Menu Category")]
        public int MenuCategoryId { get; set; }
        public virtual MenuCategory MenuCategorys { get; set; }

        [ForeignKey("SecurityUserCooks")]
        [Required]
        [Description("Relationships with Cook")]
        public int CookId { get; set; }
        public virtual SecurityUser SecurityUserCooks { get; set; }

        [ForeignKey("BusinessZones")]
        [Required]
        [Description("Relationships with BusinessZone")]
        public int BusinessZoneId { get; set; }
        public virtual BusinessZone BusinessZones { get; set; }

        #endregion

        #region Model Property

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(300)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(max)")]
        public string RootUrl { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(1000)]
        public string FileName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string FileExtention { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Description { get; set; }

        [Required]
        public decimal CookPrice { get; set; }

        [Required]
        public decimal CompanyPrice { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        #endregion

        #region NoMapping Property


        [NotMapped]
        public string ImageUrl => RootUrl + "/" + FileName + "/" + FileExtention;

        #endregion
    }
}
