using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsEntity.Model
{
  public class SubZone
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

        #endregion

        #region Model Property

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string Latlng { get; set; }
        #endregion

        #region NoMapping Property


        #endregion
    }
}
