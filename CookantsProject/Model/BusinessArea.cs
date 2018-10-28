using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookantsEntity.Model
{
   public class BusinessArea
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  // Primary Key


        #region ForeignKey Property


        #endregion

        #region Model Property

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string ShortName { get; set; }

        public bool IsActive { get; set; }

        #endregion

        #region NoMapping Property


        #endregion

    }
}
