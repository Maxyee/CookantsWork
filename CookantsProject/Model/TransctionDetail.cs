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
    public class TransctionDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }

        #region ForeignKey Property

        [ForeignKey("Particulars")]
        [Description("Relationships with Particulars")]
        public int ParticularsId { get; set; }
        public virtual SecurityUser Particulars { get; set; }

        [ForeignKey("Transctions")]
        [Description("Relationships with Transctions")]
        public int TransctionId { get; set; }
        public virtual Transction Transctions { get; set; }


        #endregion

        #region Model Property

        public decimal? CreditBalance { get; set; }

        public decimal? DebitBalance { get; set; }

        #endregion

        #region NoMapping Property


        #endregion
    }
}
