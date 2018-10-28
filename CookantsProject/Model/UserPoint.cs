using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookantsEntity.Model
{
   public  class UserPoint
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }

        #region ForeignKey Property
        [ForeignKey("OrderItems")]
        [Required]
        [Description("Relationships with OrderItems")]
        public int OrderItemId { get; set; }
        public virtual OrderItem OrderItems { get; set; }

        [ForeignKey("ReferenceByUser")]
        [Required]
        [Description("Relationships with ReferenceByUser")]
        public int ReferenceByUserId { get; set; }
        public virtual SecurityUser ReferenceByUser { get; set; }


        [ForeignKey("ReferenceToUser")]
        [Required]
        [Description("Relationships with ReferenceToUser")]
        public int ReferenceToUserId { get; set; }
        public virtual SecurityUser ReferenceToUser { get; set; }
        #endregion

        #region Model Property

        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string PointType { get; set; }

        [Required]
        public decimal Point { get; set; } 

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Comment { get; set; }

        #endregion

        #region NoMapping Property


        #endregion
    }
}
