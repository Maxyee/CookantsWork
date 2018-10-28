using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookantsEntity.Model
{
    public class MenuSchedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }


        #region ForeignKey Property

        [ForeignKey("MenuItems")]
        [Required]
        [Description("Relationships with Menu Item")]
        public int MenuItemId { get; set; }
        public virtual MenuItem MenuItems { get; set; }

        [ForeignKey("BusinessZones")]
        [Description("Relationships with businessZone")]
        public int? BusinessZoneId { get; set; }
        public virtual BusinessZone BusinessZones { get; set; }

        [ForeignKey("Cooks")]
        [Description("Relationships with Cook")]
        public int? CookId { get; set; }
        public virtual SecurityUser Cooks { get; set; }


        [ForeignKey("MealTimes")]
        [Description("Relationships with MealTimes")]
        public int? MealId { get; set; }
        public virtual MealTime MealTimes { get; set; }


        #endregion

        #region Model Property


        [Required]
        public int Quantity { get; set; }

        public int OrderQuantity { get; set; }

        public int ActualDeliveryQuantity { get; set; }

        public bool IsWithdraw { get; set; }

        public bool IsPaid { get; set; }

        public DateTime? PaidDate { get; set; }

        [Required]
        public DateTime Date { get; set; }




        #endregion

        #region NoMapping Property


        #endregion
    }

}
