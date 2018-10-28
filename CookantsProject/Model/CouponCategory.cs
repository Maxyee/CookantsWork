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
    public class CouponCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }

        #region Model Property

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string Name { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        public bool isActive { get; set; }

        #endregion

        #region NoMapping Property


        #endregion
    }
}
