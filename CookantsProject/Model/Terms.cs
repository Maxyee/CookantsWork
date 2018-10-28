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
    public class Terms
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }

        #region ForeignKey Property

        #endregion

        #region Model Property

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string Title { get; set; } // use for Title

        [Required]
        [Column(TypeName = "varchar")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        #endregion

        #region NoMapping Property
        #endregion
    }
}
