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
    public class DeliveryOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }


        #region ForeignKey Property

        [ForeignKey("Customer")]
        [Required]
        [Description("Relationships with SecurityUser")]
        public int CustomerId { get; set; }
        public virtual SecurityUser Customer { get; set; }

        [ForeignKey("DeliveryMan")]
        [Description("Relationships with SecurityUser")]
        public int DeliveryManId { get; set; }
        public virtual SecurityUser DeliveryMan { get; set; }

        [ForeignKey("DeliveryOrderItem")]
        [Description("Relationships with OrderItem")]
        public int DeliveryOrderItemId { get; set; }
        public virtual OrderItem DeliveryOrderItem { get; set; }
        #endregion



        #region Model Property

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        public string DeliveryAddress { get; set; }

        public DateTime? OrderDate { get; set; }

        [DefaultValue(false)]
        public Boolean isDelivered { get; set; }

        #endregion
    }
}
