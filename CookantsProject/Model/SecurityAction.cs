using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookantsEntity.Model
{
    public class SecurityAction
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
        [StringLength(50)]
        public string ApiController { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string ActionName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string ParameterName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string DisplayName { get; set; }

        #endregion

        #region NoMapping Property


        #endregion


    }
}
