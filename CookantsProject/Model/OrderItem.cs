using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookantsEntity.Model
{
   public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }


        #region ForeignKey Property

        [ForeignKey("Orders")]
        [Required]
        [Description("Relationships with Order")]
        public int OrderId { get; set; }
        public virtual Order Orders { get; set; }


        [ForeignKey("MenuItems")]
        [Required]
        [Description("Relationships with MenuItem")]
        public int MenuItemId { get; set; }
        public virtual MenuItem MenuItems { get; set; }
        #endregion

        #region Model Property

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }
        public DateTime? OrderDate { get; set; }


        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan EndTime { get; set; }
        public bool IsRating { get; set; }
        public bool IsComplained { get; set; }
        #endregion

        #region NoMapping Property


        #endregion
    }
}
