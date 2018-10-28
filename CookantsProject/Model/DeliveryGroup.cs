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
    public class DeliveryGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }


        #region ForeignKey Property

        [ForeignKey("SecurityUsers")]
        [Required]
        [Description("Relationships with SecurityUser")]
        public int DeliveryBoyId { get; set; }
        public virtual SecurityUser SecurityUsers { get; set; }

        [ForeignKey("SubZones")]
        [Description("Relationships with SubZones")]
        public int SubZoneId { get; set; }
        public virtual SubZone SubZones { get; set; }
        #endregion

        #region Model Property

        [Required]
        public int MaxDeliverItems { get; set; }

      
        [Required]
        public int Priority { get; set; }
        #endregion

        #region NoMapping Property

        #endregion
    }
}
