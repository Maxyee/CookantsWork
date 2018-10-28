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
    public class PickupOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }


        #region ForeignKey Property

        [ForeignKey("Chef")]
        [Required]
        [Description("Relationships with SecurityUser")]
        public int ChefId { get; set; }
        public virtual SecurityUser Chef { get; set; }

        [ForeignKey("DeliveryMan")]
        [Description("Relationships with SecurityUser")]
        public int DeliveryManId { get; set; }
        public virtual SecurityUser DeliveryMan { get; set; }

        [ForeignKey("PickOrderItem")]
        [Description("Relationships with OrderItem")]
        public int PickOrderItemId { get; set; }
        public virtual OrderItem PickOrderItem { get; set; }
        #endregion



        #region Model Property

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        public string PickAddress { get; set; }

     
        public DateTime? OrderDate { get; set; }

        [DefaultValue(false)]
        public Boolean isPickuped { get; set; }

        #endregion
    }
}
