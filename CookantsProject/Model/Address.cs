using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookantsEntity.Model
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }


        #region ForeignKey Property

        [ForeignKey("BusinessZone")]
        [Required]
        [Description("Relationships with BusinessZone")]
        public int BusinessZoneId { get; set; }
        public virtual BusinessZone BusinessZone { get; set; }

        [ForeignKey("SubZones")]
        [Required]
        [Description("Relationships with SubZones")]
        public int SubZoneId { get; set; }
        public virtual SubZone SubZones { get; set; }

        #endregion

        #region Model Property
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string FlatNO { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string HouseNo { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string RoadNo { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        public string Description { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string Latlng { get; set; }

        #endregion

        #region NoMapping Property


        #endregion
    }
}


