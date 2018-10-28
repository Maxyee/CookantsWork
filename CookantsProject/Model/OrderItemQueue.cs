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
  public  class OrderItemQueue
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

        [ForeignKey("Chef")]
        [Description("Relationships with SecurityUser")]
        public int ChefId { get; set; }
        public virtual SecurityUser Chef { get; set; }

        [ForeignKey("QueueOrderItem")]
        [Description("Relationships with OrderItem")]
        public int QueueOrderItemId { get; set; }
        public virtual OrderItem QueueOrderItem { get; set; }
        #endregion



        #region Model Property

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        public string DeliveryAddress { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        public string pickupAddress { get; set; }

        public DateTime? OrderDate { get; set; }

        [Required]
        public int QueueType { get; set; }

        #endregion

    }
}
