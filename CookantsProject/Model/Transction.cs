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
    public class Transction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }
        #region ForeignKey Property
        #endregion
        #region Model Property
        public DateTime CreateDate { get; set; }
        public string VoucherNo { get; set; }
        public string Notes { get; set; }
        #endregion

        #region NoMapping Property


        #endregion
    }
}
