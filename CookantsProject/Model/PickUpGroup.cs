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
    public class PickUpGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }


        #region ForeignKey Property

        [ForeignKey("DeliveryBoy")]
        [Required]
        [Description("Relationships with SecurityUser")]
        public int DeliveryBoyId { get; set; }
        public virtual SecurityUser DeliveryBoy { get; set; }

        [ForeignKey("HomeChefs")]
        [Required]
        [Description("Relationships with SecurityUsers")]
        public int ChefId { get; set; }
        public virtual SecurityUser HomeChefs { get; set; }
        #endregion

        #region Model Property

        [Required]
        public int MaxPickUpItems { get; set; }


        [Required]
        public int Priority { get; set; }
        #endregion

        #region NoMapping Property

        #endregion
    }
}
