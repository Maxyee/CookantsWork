using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookantsEntity.Model
{
   public class BusinessZone
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; } 


        #region ForeignKey Property

        [ForeignKey("BusinessAreas")]
        [Required]
        [Description("Relationships with BusinessArea")]
        public int BusinessAreaId { get; set; }
        public virtual BusinessArea BusinessAreas { get; set; }

        [ForeignKey("ZoneColors")]
        [Description("Relationships with ZoneColors")]
        public int? ColorId { get; set; }
        public virtual ZoneColor ZoneColors { get; set; }
        #endregion

        #region Model Property

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string ShortName { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string Code { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string Latlng { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string ExchangeAddress { get; set; }

        [DefaultValue("")]
        [Column(TypeName = "varchar")]
        public string ExchangePoint { get; set; }


        [Required]
        public decimal DeliveryCost { get; set; }
        #endregion

        #region NoMapping Property

        public string DisplayCode => ShortName + "" + Code;

       #endregion
    }
}
