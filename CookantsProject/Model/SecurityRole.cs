using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookantsEntity.Model
{
   public class SecurityRole
   {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("Primary Key")]
        public int Id { get; set; }  // Primary Key

        #region ForeignKey Property


        #endregion


        #region Model Property

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Name { get; set; }

        #endregion

        #region NoMapping Property


        #endregion

    }
}
