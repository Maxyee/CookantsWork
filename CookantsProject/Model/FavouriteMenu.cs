using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookantsEntity.Model
{
   public class FavouriteMenu
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

        [ForeignKey("Coock")]
        [Description("Relationships with Coock")]
        public int? CoockId { get; set; }
        public virtual SecurityUser Coock { get; set; }

        [ForeignKey("MenuCategorys")]
        [Description("Relationships with MenuCategory")]
        public int? MenuCategoryId { get; set; }
        public virtual MenuCategory MenuCategorys { get; set; }

        #endregion

        #region Model Property


        #endregion

        #region NoMapping Property


        #endregion
    }
}
