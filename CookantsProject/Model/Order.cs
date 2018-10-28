using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookantsEntity.Model
{
   public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }


        #region ForeignKey Property

        [ForeignKey("SecurityUserCustomers")]
        [Required]
        [Description("Relationships with Customer")]
        public int CustomerId { get; set; }
        public virtual SecurityUser SecurityUserCustomers { get; set; }

        [ForeignKey("SecurityUserDeliveryBoy")]
     
        [Description("Relationships with DeliveryBoy")]
        public int? DeliveryBoyId { get; set; }
        public virtual SecurityUser SecurityUserDeliveryBoy { get; set; }

        [ForeignKey("BusinessZones")]
        [Required]
        [Description("Relationships with Business Zone")]
        public int BusinessZoneId { get; set; }
        public virtual BusinessZone BusinessZones { get; set; }

        [ForeignKey("Addresss")]
        [Required]
        [Description("Relationships with Addresss")]
        public int AddressId { get; set; }
        public virtual Address Addresss { get; set; }

        [ForeignKey("MealTimes")]
        [Description("Relationships with MealTimes")]
        public int? MealId { get; set; }
        public virtual MealTime MealTimes { get; set; }
        #endregion

        #region Model Property

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string OrderNumber { get; set; }        

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        public decimal DeliveryCost { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        public DateTime? DelivereyDate { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Description("Pending, Cancel ,Cooking ,PickUp, Delivered,Not Deliverd")]
        public string DelivereyStatus { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Description("CashOnDelivery, Bkash ,Paypal")]
        public string PaymentMethod  { get; set; }
        public bool PaymentStatus { get; set; }

        #endregion

        #region NoMapping Property

        [NotMapped]
        public List<OrderItem> OrderItems { get; set; }

       

        #endregion
    }
}
