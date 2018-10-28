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
    public class Coupon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }
        #region ForeignKey Property
        [ForeignKey("CouponCategories")]
        [Required]
        [Description("Relationships with CouponCategories")]
        public int CouponCategoryId { get; set; }
        public virtual CouponCategory CouponCategories { get; set; }
        #endregion
        #region Model Property

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string CuponCode { get; set; }
        [Required]
        public decimal DiscountAmount { get; set; }
        public int? Uses { get; set; }
        public int MaxUses { get; set; }
        public int MaxUserUses { get; set; }
        public bool isActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpireDate { get; set; }
        #endregion

        #region NoMapping Property


        #endregion
    }

}
