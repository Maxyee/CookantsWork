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
    public class UserAccounting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }


        #region ForeignKey Property

        [ForeignKey("Users")]
        [Required]
        [Description("Relationships with Users")]
        public int UserId { get; set; }
        public virtual SecurityUser Users { get; set; }
        #endregion

        #region Model Propertys

        public decimal PaidAmount { get; set; }

        public decimal WithdrawAmount { get; set; }

        public bool IsWithdraw { get; set; }

        public DateTime? WithdrawDate { get; set; }

        public bool IsPaid { get; set; }

        public DateTime? PaidDate { get; set; }

        [Required]
        public DateTime Date { get; set; }

        #endregion

        #region NoMapping Property


        #endregion
    }
}
